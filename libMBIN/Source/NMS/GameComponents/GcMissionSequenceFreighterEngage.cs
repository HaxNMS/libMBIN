﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x220, GUID = 0x36CC0CF9D3A92382, SubGUID = 0x5755416737105B76)]
    public class GcMissionSequenceFreighterEngage : NMSTemplate      // size: 0x180
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
        /* 0x100 */ public float EngageDistance;
        /* 0x104 */ public float EngageTime;
        /* 0x108 */ public float TimeAfterWarp;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10C */ public byte[] Padding10C;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string TimeoutMessage;
        [NMS(Size = 0x80)]
        /* 0x120 */ public string TimeoutOSDMessage;
        [NMS(Size = 0x80)]
        /* 0x1A0 */ public string DebugText;
    }
}
