#pragma once
#include "stdafx.h"
#include "BaseControlDevice.h"

struct ZapperButtonState
{
	bool TriggerPressed = false;
	bool LightNotDetected = false;

	uint8_t ToByte()
	{
		return (LightNotDetected ? 0x08 : 0x00) | (TriggerPressed ? 0x10 : 0x00);
	}
};

class Zapper : public BaseControlDevice
{
private:
	bool _pulled = false;
	int32_t _xPosition = -1;
	int32_t _yPosition = -1;

protected:
	virtual uint8_t RefreshState();
	uint8_t ProcessNetPlayState(uint32_t netplayState);
	void StreamState(bool saving);
	ZapperButtonState GetZapperState();

public:
	using BaseControlDevice::BaseControlDevice;

	virtual uint8_t GetPortOutput();

	virtual uint32_t GetNetPlayState();
};