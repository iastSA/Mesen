#pragma once
#include "stdafx.h"
#include "BaseMapper.h"

class AXROM : public BaseMapper
{
	protected:
		virtual uint16_t GetPRGPageSize() { return 0x8000; }
		virtual uint16_t GetCHRPageSize() {	return 0x2000; }

		void InitMapper() 
		{
			SelectPRGPage(0, 0);
			SelectCHRPage(0, 0);
		}

		bool HasBusConflicts() { return _subMapperID == 2; }

		void WriteRegister(uint16_t addr, uint8_t value)
		{
			SelectPRGPage(0, value & 0x0F);

			SetMirroringType(((value & 0x10) == 0x10) ? MirroringType::ScreenBOnly : MirroringType::ScreenAOnly);
		}
};