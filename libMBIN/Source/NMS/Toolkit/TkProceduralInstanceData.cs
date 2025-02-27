﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x9E8977C498CF111F, SubGUID = 0x9B97135AE5A6E0F1)]
    public class TkProceduralInstanceData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Index;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
