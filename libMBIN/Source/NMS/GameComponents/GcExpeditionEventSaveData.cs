﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xA49F85CEFDDB1020, SubGUID = 0xA95CE4EF897F62B2)]
    public class GcExpeditionEventSaveData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public ulong UA;
        /* 0x18 */ public List<int> AffectedFrigateIndices;
        /* 0x28 */ public List<int> RepairingFrigateIndices;
        /* 0x38 */ public List<int> AffectedFrigateResponses;
        [NMS(Size = 0x20)]
        /* 0x48 */ public string EventID;
        [NMS(Size = 0x20)]
        /* 0x68 */ public string InterventionEventID;
        [NMS(Size = 0x10)]
        /* 0x88 */ public string OverriddenDescription;
        /* 0x98 */ public bool Success;
        /* 0x99 */ public bool IsInterventionEvent;
        /* 0x9A */ public bool AvoidedIntervention;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x9B */ public byte[] EndPadding;
    }
}
