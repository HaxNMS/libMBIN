﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, Alignment = 0x8, GUID = 0x2CFDA1347C0D985F, SubGUID = 0x51E8334202D1B952)]
    public class GcExternalObjectListOptions : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
		[NMS(Size = 0x10)]
		/* 0x10 */ public string ResourceHint;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string ResourceHintIcon;
        /* 0x30 */ public float Probability;
        /* 0x34 */ public GcTerrainTileType TileType;
        /* 0x38 */ public bool AllowLimiting;
        /* 0x39 */ public bool ChooseUsingLifeLevel;
        [NMS(Size = 6, Ignore = true)]
        /* 0x3A */ public byte[] Padding3A;
        /* 0x40 */ public List<NMSString0x80> Options;
    }
}
