// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public interface CAdapterSteamController001
	{
		[VTableSlot(0)]
		Int32 Init();
		[VTableSlot(1)]
		Int32 Shutdown();
		[VTableSlot(2)]
		Int32 RunFrame();
		[VTableSlot(3)]
		Int32 GetControllerState(UInt32 uUnk, ref SteamControllerState_t pState);
	};
}