﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0xB6384592780899EB, SubGUID = 0xF6BA3ABDC071904B)]
    public class GcRewardCustomExpeditionLogEntry : NMSTemplate
    {
        [NMS(Size = 0x40)]
        public string LocID;
    }
}
