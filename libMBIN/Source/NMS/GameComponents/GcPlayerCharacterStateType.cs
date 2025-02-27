﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBFF28650472EBD3C, SubGUID = 0xDACE1F471447B685)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
        // 0x10 entries
		public enum CharacterStateEnum { Idle, Jog, JogUphill, JogDownhill, SteepSlope, Sliding, Run, Airborne, JetpackBoost, RocketBoots, Riding, Swimming,
            SwimmingJetpack, Death, FullBodyOverride, InSpace }
		public CharacterStateEnum CharacterState;
    }
}
