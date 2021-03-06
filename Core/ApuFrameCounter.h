#pragma once
#include "stdafx.h"
#include "IMemoryHandler.h"
#include "CPU.h"
#include "EmulationSettings.h"

enum class FrameType
{
	None = 0,
	QuarterFrame = 1,
	HalfFrame = 2,
};

class ApuFrameCounter : public IMemoryHandler, public Snapshotable
{
private:
	const vector<vector<int32_t>> _stepCyclesNtsc = { { { 7457, 14913, 22371, 29828, 29829, 29830},
																		 { 7457, 14913, 22371, 29829, 37281, 37282} } };
	const vector<vector<int32_t>> _stepCyclesPal =  { { { 8313, 16627, 24939, 33252, 33253, 33254},
																		 { 8313, 16627, 24939, 33253, 41565, 41566} } };
	const vector<vector<FrameType>> _frameType = { { { FrameType::QuarterFrame, FrameType::HalfFrame, FrameType::QuarterFrame, FrameType::None, FrameType::HalfFrame, FrameType::None },
																	 { FrameType::QuarterFrame, FrameType::HalfFrame, FrameType::QuarterFrame, FrameType::None, FrameType::HalfFrame, FrameType::None } } };

	vector<vector<int32_t>> _stepCycles;
	NesModel _nesModel;
	int32_t _nextIrqCycle;
	int32_t _previousCycle;
	uint32_t _currentStep;
	uint32_t _stepMode; //0: 4-step mode, 1: 5-step mode
	bool _inhibitIRQ;
	uint8_t _blockFrameCounterTick;
	int16_t _newValue;
	int8_t _writeDelayCounter;

	void (*_callback)(FrameType);

public:
	ApuFrameCounter(void (*frameCounterTickCallback)(FrameType))
	{
		_callback = frameCounterTickCallback;
		Reset(false);
	}

	void Reset(bool softReset)
	{
		_nextIrqCycle = 29828;

		//"After reset or power-up, APU acts as if $4017 were written with $00 from 9 to 12 clocks before first instruction begins."
		//Because of the 3-4 sequence reset delay, 9-12 clocks turns into 6-7
		_previousCycle = 6;

		//"After reset: APU mode in $4017 was unchanged", so we need to keep whatever value _stepMode has for soft resets
		if(!softReset) {
			_stepMode = 0;
		}

		_currentStep = 0;
		_inhibitIRQ = false;

		_blockFrameCounterTick = 0;
		_newValue = -1;
		_writeDelayCounter = -1;
	}

	void StreamState(bool saving)
	{
		Stream(_nextIrqCycle, _previousCycle, _currentStep, _stepMode, _inhibitIRQ, _nesModel, _blockFrameCounterTick, _writeDelayCounter, _newValue);

		if(!saving) {
			SetNesModel(_nesModel);
		}
	}

	void SetNesModel(NesModel model)
	{
		if(_nesModel != model || _stepCycles.size() == 0) {
			_nesModel = model;
			_stepCycles.clear();
			switch(model) {
				case NesModel::NTSC:
				case NesModel::Dendy:
					_stepCycles.push_back(_stepCyclesNtsc[0]);
					_stepCycles.push_back(_stepCyclesNtsc[1]);
					break;
				
				case NesModel::PAL:
					_stepCycles.push_back(_stepCyclesPal[0]);
					_stepCycles.push_back(_stepCyclesPal[1]);
					break;
			}
		}
	}

	uint32_t Run(int32_t &cyclesToRun)
	{
		uint32_t cyclesRan;
		
		if(_previousCycle + cyclesToRun >= _stepCycles[_stepMode][_currentStep]) {
			if(!_inhibitIRQ && _stepMode == 0 && _currentStep >= 3) {
				//Set irq on the last 3 cycles for 4-step mode
				CPU::SetIRQSource(IRQSource::FrameCounter);
				_nextIrqCycle++;
			}

			FrameType type = _frameType[_stepMode][_currentStep];
			if(type != FrameType::None && !_blockFrameCounterTick) {
				_callback(type);
				
				//Do not allow writes to 4017 to clock the frame counter for the next cycle (i.e this odd cycle + the following even cycle)
				_blockFrameCounterTick = 2;
			}

			if(_stepCycles[_stepMode][_currentStep] < _previousCycle) {
				//This can happen when switching from PAL to NTSC, which can cause a freeze (endless loop in APU)
				cyclesRan = 0;
			} else {
				cyclesRan = _stepCycles[_stepMode][_currentStep] - _previousCycle;
			}
			
			cyclesToRun -= cyclesRan;

			_currentStep++;
			if(_currentStep == 6) {
				_currentStep = 0;
				_previousCycle = 0;
				if(_stepMode == 0 && !_inhibitIRQ) {
					_nextIrqCycle = 29828;
				}
			} else {
				_previousCycle += cyclesRan;
			}
		} else {
			cyclesRan = cyclesToRun;
			cyclesToRun = 0;
			_previousCycle += cyclesRan;
		}

		if(_newValue >= 0) {
			_writeDelayCounter--;
			if(_writeDelayCounter == 0) {
				//Apply new value after the appropriate number of cycles has elapsed
				_stepMode = ((_newValue & 0x80) == 0x80) ? 1 : 0;

				if(!_inhibitIRQ && _stepMode == 0) {
					_nextIrqCycle = 29828;
				} else {
					_nextIrqCycle = -1;
				}

				_writeDelayCounter = -1;
				_currentStep = 0;
				_previousCycle = 0;
				_newValue = -1;

				if(_stepMode && !_blockFrameCounterTick) {
					//"Writing to $4017 with bit 7 set will immediately generate a clock for both the quarter frame and the half frame units, regardless of what the sequencer is doing."
					_callback(FrameType::HalfFrame);
					_blockFrameCounterTick = 2;
				}
			}
		}
		
		if(_blockFrameCounterTick > 0) {
			_blockFrameCounterTick--;
		}

		return cyclesRan;
	}

	bool IrqPending(uint32_t cyclesToRun)
	{
		if(_newValue >= 0 || _blockFrameCounterTick > 0) {
			return true;
		}

		if(_previousCycle + (int32_t)cyclesToRun >= _stepCycles[_stepMode][_currentStep]) {
			return true;
		}

		if(_nextIrqCycle != -1) {
			if(_previousCycle + cyclesToRun >= (uint32_t)_nextIrqCycle) {
				return true;
			}
		}
		return false;
	}

	void GetMemoryRanges(MemoryRanges &ranges)
	{
		ranges.AddHandler(MemoryOperation::Write, 0x4017);
	}

	uint8_t ReadRAM(uint16_t addr)
	{
		return 0;
	}

	void WriteRAM(uint16_t addr, uint8_t value)
	{
		APU::StaticRun();
		_newValue = value;

		//Reset sequence after $4017 is written to
		if(CPU::GetCycleCount() & 0x01) {
			//"If the write occurs during an APU cycle, the effects occur 3 CPU cycles after the $4017 write cycle"
			_writeDelayCounter = 3;
		} else {
			//"If the write occurs between APU cycles, the effects occur 4 CPU cycles after the write cycle. "
			_writeDelayCounter = 4;
		}

		_inhibitIRQ = (value & 0x40) == 0x40;
		if(_inhibitIRQ) {
			CPU::ClearIRQSource(IRQSource::FrameCounter);
		}
	}
};