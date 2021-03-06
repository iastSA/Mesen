#pragma once

#include "stdafx.h"
#include "../Core/IRenderingDevice.h"
#include "../Core/IMessageManager.h"
#include "../Core/EmulationSettings.h"
#include "../Utilities/FolderUtilities.h"
#include "../Utilities/SimpleLock.h"
#include "../Utilities/Timer.h"

using namespace DirectX;

namespace DirectX {
	class SpriteBatch;
	class SpriteFont;
}

namespace NES {
	class Renderer : public IRenderingDevice, public IMessageManager
	{
	private:
		HWND                    _hWnd = nullptr;

		ID3D11Device*           _pd3dDevice = nullptr;
		ID3D11DeviceContext*    _pDeviceContext = nullptr;
		IDXGISwapChain*         _pSwapChain = nullptr;
		ID3D11RenderTargetView* _pRenderTargetView = nullptr;
		ID3D11DepthStencilState* _pDepthDisabledStencilState = nullptr;
		ID3D11BlendState*			_pAlphaEnableBlendingState = nullptr;

		ID3D11SamplerState*		_samplerState = nullptr;
		
		atomic<bool>				_needFlip = false;
		uint8_t*						_textureBuffer[2] = { nullptr, nullptr };
		ID3D11Texture2D*			_pTexture = nullptr;
		ID3D11ShaderResourceView*	_pTextureSrv = nullptr;
		ID3D11Texture2D*			_overlayTexture = nullptr;
		ID3D11ShaderResourceView*	_pOverlaySrv = nullptr;

		bool							_frameChanged = true;
		SimpleLock					_frameLock;
		SimpleLock					_textureLock;

		VideoResizeFilter _resizeFilter = VideoResizeFilter::NearestNeighbor;

		Timer _fpsTimer;
		uint32_t _lastFrameCount = 0;
		uint32_t _renderedFrameCount = 0;
		uint32_t _lastRenderedFrameCount = 0;
		uint32_t _currentFPS = 0;
		uint32_t _currentRenderedFPS = 0;

		unique_ptr<SpriteFont>	_font;
		unique_ptr<SpriteFont>	_largeFont;
		
		unique_ptr<SpriteBatch> _spriteBatch;

		const uint32_t _bytesPerPixel = 4;
		uint32_t _screenWidth = 0;
		uint32_t _screenHeight = 0;
		uint32_t _screenBufferSize = 0;

		uint32_t _nesFrameHeight = 0;
		uint32_t _nesFrameWidth = 0;
		uint32_t _newFrameBufferSize = 0;

		uint32_t _noUpdateCount = 0;

		list<shared_ptr<ToastInfo>> _toasts;
		//ID3D11ShaderResourceView* _toastTexture = nullptr;

		HRESULT InitDevice();
		void CleanupDevice();

		void SetScreenSize(uint32_t width, uint32_t height);

		ID3D11Texture2D* CreateTexture(uint32_t width, uint32_t height);
		ID3D11ShaderResourceView* GetShaderResourceView(ID3D11Texture2D* texture);
		void DrawNESScreen();
		void DrawPauseScreen();

		std::wstring WrapText(string text, SpriteFont* font, float maxLineWidth, uint32_t &lineCount);
		void DrawString(string message, float x, float y, DirectX::FXMVECTOR color, float scale, SpriteFont* font = nullptr);
		void DrawString(std::wstring message, float x, float y, DirectX::FXMVECTOR color, float scale, SpriteFont* font = nullptr);

		void DrawToasts();
		void DrawToast(shared_ptr<ToastInfo> toast, int &lastHeight);
		void RemoveOldToasts();

		void ShowFpsCounter();
		void ShowLagCounter();
	
	public:
		Renderer(HWND hWnd);
		~Renderer();

		void Reset();
		void Render();
		void DisplayMessage(string title, string message);

		void UpdateFrame(void *frameBuffer, uint32_t width, uint32_t height);
	};
}