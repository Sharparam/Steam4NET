// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMUSERSTATS_INTERFACE_VERSION001")]
	public interface ISteamUserStats001
	{
		[VTableSlot(0)]
		UInt32 GetNumStats(CGameID nGameID);
		[VTableSlot(1)]
		string GetStatName(CGameID nGameID, UInt32 iStat);
		[VTableSlot(2)]
		ESteamUserStatType GetStatType(CGameID nGameID, string pchName);
		[VTableSlot(3)]
		UInt32 GetNumAchievements(CGameID nGameID);
		[VTableSlot(4)]
		string GetAchievementName(CGameID nGameID, UInt32 iAchievement);
		[VTableSlot(5)]
		UInt32 GetNumGroupAchievements(CGameID arg0);
		[VTableSlot(6)]
		string GetGroupAchievementName(CGameID arg0, UInt32 iAchievement);
		[VTableSlot(7)]
		bool RequestCurrentStats(CGameID nGameID);
		[VTableSlot(8)]
		bool GetStat(CGameID nGameID, string pchName, ref float pData);
		[VTableSlot(9)]
		bool GetStat(CGameID nGameID, string pchName, ref Int32 pData);
		[VTableSlot(10)]
		bool SetStat(CGameID nGameID, string pchName, float fData);
		[VTableSlot(11)]
		bool SetStat(CGameID nGameID, string pchName, Int32 nData);
		[VTableSlot(12)]
		bool UpdateAvgRateStat(CGameID nGameID, string pchName, float arg2, double dSessionLength);
		[VTableSlot(13)]
		bool GetAchievement(CGameID nGameID, string pchName, ref bool pbAchieved);
		[VTableSlot(14)]
		bool GetGroupAchievement(CGameID nGameID, string pchName, ref bool pbAchieved);
		[VTableSlot(15)]
		bool SetAchievement(CGameID nGameID, string pchName);
		[VTableSlot(16)]
		bool SetGroupAchievement(CGameID nGameID, string pchName);
		[VTableSlot(17)]
		bool StoreStats(CGameID nGameID);
		[VTableSlot(18)]
		bool ClearAchievement(CGameID nGameID, string pchName);
		[VTableSlot(19)]
		bool ClearGroupAchievement(CGameID nGameID, string pchName);
		[VTableSlot(20)]
		Int32 GetAchievementIcon(CGameID nGameID, string pchName);
		[VTableSlot(21)]
		string GetAchievementDisplayAttribute(CGameID nGameID, string pchName, string pchKey);
	};
}
