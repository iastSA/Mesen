#pragma once
#include "BaseMapper.h"
#include "VrcIrq.h"

class Waixing252 : public BaseMapper
{
private:
	uint8_t _chrRegs[8];
	VrcIrq _irq;

protected:
	uint16_t GetPRGPageSize() { return 0x2000; }
	uint16_t GetCHRPageSize() { return 0x400; }

	void InitMapper()
	{
		memset(_chrRegs, 0, sizeof(_chrRegs));

		SelectPRGPage(2, -2);
		SelectPRGPage(3, -1);
	}

	void StreamState(bool saving)
	{
		BaseMapper::StreamState(saving);
		SnapshotInfo irq{ &_irq };
		ArrayInfo<uint8_t> chrRegs{ _chrRegs,8 };
		Stream(chrRegs, irq);

		if(!saving) {
			UpdateState();
		}
	}

	void ProcessCpuClock()
	{
		_irq.ProcessCpuClock();
	}

	void UpdateState()
	{
		for(int i = 0; i < 8; i++) {
			//CHR needs to be writeable (according to Nestopia's source, and this does remove visual glitches from the game)
			SetPpuMemoryMapping(0x400 * i, 0x400 * i + 0x3FF, _chrRegs[i], ChrMemoryType::Default, MemoryAccessType::ReadWrite);
		}
	}

	void WriteRegister(uint16_t addr, uint8_t value)
	{
		if(addr <= 0x8FFF) {
			SelectPRGPage(0, value);
		} else if(addr >= 0xA000 && addr <= 0xAFFF) {
			SelectPRGPage(1, value);
		} else if(addr >= 0xB000 && addr <= 0xEFFF) {
			uint8_t shift = addr & 0x4;
			uint8_t bank = (((addr - 0xB000) >> 1 & 0x1800) | (addr << 7 & 0x0400)) / 0x400;
			_chrRegs[bank] = ((_chrRegs[bank] & (0xF0 >> shift)) | ((value & 0x0F) << shift));
			UpdateState();
		} else {
			switch(addr & 0xF00C) {
				case 0xF000: _irq.SetReloadValueNibble(value, false); break;
				case 0xF004: _irq.SetReloadValueNibble(value, true); break;
				case 0xF008: _irq.SetControlValue(value); break;
				case 0xF00C: _irq.AcknowledgeIrq(); break;
			}
		}
	}
};