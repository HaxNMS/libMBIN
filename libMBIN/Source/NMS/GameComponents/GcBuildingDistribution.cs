﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x401D8256EF89A26A, SubGUID = 0xF28B5D3A889453A9)]
    public class GcBuildingDistribution : NMSTemplate // size: 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public int MinDistance;
        public int MaxDistance;
    }
}
