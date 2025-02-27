﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xE3C442F66A5D2D95, SubGUID = 0x4D3FB3BF1BEB7DAE)]
    public class GcPlayerCharacterIKStateData : NMSTemplate
    {
        public GcPlayerCharacterStateType State;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        public GcPlayerCharacterIKOverrideData Data;
        public List<GcPlayerCharacterAnimationOverrideData> AnimOverrides;
    }
}
