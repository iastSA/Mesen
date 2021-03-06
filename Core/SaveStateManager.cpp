#include "stdafx.h"

#include "SaveStateManager.h"
#include "MessageManager.h"
#include "Console.h"
#include "../Utilities/FolderUtilities.h"
#include "EmulationSettings.h"

const uint32_t SaveStateManager::FileFormatVersion;
atomic<uint32_t> SaveStateManager::_lastIndex = 1;

string SaveStateManager::GetStateFilepath(int stateIndex)
{
	string folder = FolderUtilities::GetSaveStateFolder();
	string filename = FolderUtilities::GetFilename(Console::GetRomName(), false) + "_" + std::to_string(stateIndex) + ".mst";	
	return FolderUtilities::CombinePath(folder, filename);
}

uint64_t SaveStateManager::GetStateInfo(int stateIndex)
{
	string filepath = SaveStateManager::GetStateFilepath(stateIndex);
	ifstream file(filepath, ios::in | ios::binary);

	if(file) {
		file.close();
		return FolderUtilities::GetFileModificationTime(filepath);
	}
	return 0;
}

void SaveStateManager::MoveToNextSlot()
{
	_lastIndex = (_lastIndex % MaxIndex) + 1;
	MessageManager::DisplayMessage("SaveStates", "SaveStateSlotSelected", std::to_string(_lastIndex));
}

void SaveStateManager::MoveToPreviousSlot()
{
	_lastIndex = (_lastIndex == 1 ? SaveStateManager::MaxIndex : (_lastIndex - 1));
	MessageManager::DisplayMessage("SaveStates", "SaveStateSlotSelected", std::to_string(_lastIndex));
}

void SaveStateManager::SaveState()
{
	SaveState(_lastIndex);
}

bool SaveStateManager::LoadState()
{
	return LoadState(_lastIndex);
}

void SaveStateManager::SaveState(int stateIndex, bool displayMessage)
{
	string filepath = SaveStateManager::GetStateFilepath(stateIndex);
	ofstream file(filepath, ios::out | ios::binary);

	if(file) {
		_lastIndex = stateIndex;

		Console::Pause();

		uint32_t emuVersion = EmulationSettings::GetMesenVersion();
		file.write("MST", 3);
		file.write((char*)&emuVersion, sizeof(emuVersion));
		file.write((char*)&SaveStateManager::FileFormatVersion, sizeof(uint32_t));

		Console::SaveState(file);
		Console::Resume();
		file.close();		

		if(displayMessage) {
			MessageManager::DisplayMessage("SaveStates", "SaveStateSaved", std::to_string(stateIndex));
		}
	}
}

bool SaveStateManager::LoadState(int stateIndex)
{
	string filepath = SaveStateManager::GetStateFilepath(stateIndex);
	ifstream file(filepath, ios::in | ios::binary);
	bool result = false;

	if(file) {
		char header[3];
		file.read(header, 3);
		if(memcmp(header, "MST", 3) == 0) {
			uint32_t emuVersion, fileFormatVersion;

			file.read((char*)&emuVersion, sizeof(emuVersion));
			if(emuVersion > EmulationSettings::GetMesenVersion()) {
				MessageManager::DisplayMessage("SaveStates", "SaveStateNewerVersion");
				return false;
			}

			file.read((char*)&fileFormatVersion, sizeof(fileFormatVersion));
			if(fileFormatVersion != SaveStateManager::FileFormatVersion) {
				MessageManager::DisplayMessage("SaveStates", "SaveStateIncompatibleVersion", std::to_string(stateIndex));
				return false;
			}

			_lastIndex = stateIndex;

			Console::Pause();
			Console::LoadState(file);
			Console::Resume();

			MessageManager::DisplayMessage("SaveStates", "SaveStateLoaded", std::to_string(stateIndex));
			result = true;
		} else {
			MessageManager::DisplayMessage("SaveStates", "SaveStateInvalidFile");
		}
		file.close();
	} 
	
	if(!result) {
		MessageManager::DisplayMessage("SaveStates", "SaveStateEmpty");
	}

	return result;
}