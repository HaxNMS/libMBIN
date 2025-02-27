﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0x5229BF8FE535C9E2, SubGUID = 0x4B1DBAB6A4BE391D)]
    public class GcMissionSequenceAudioEvent : NMSTemplate
    {
        public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
