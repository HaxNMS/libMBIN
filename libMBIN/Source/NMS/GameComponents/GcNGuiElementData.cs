﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0xE2EB8F44BD6FD5A1, SubGUID = 0xF10587272870E7F4)]
    public class GcNGuiElementData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string PresetID;
        /* 0x20 */ public bool IsHidden;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;
        /* 0x28 */ public GcNGuiLayoutData Layout;
    }
}
