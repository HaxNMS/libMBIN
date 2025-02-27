﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x901EC91DF16D7A41, SubGUID = 0x9A637E59AB66BFB0)]
    public class GcAlienMood : NMSTemplate
    {
        // 0x9 entries
        public enum MoodEnum { Neutral, Positive, VeryPositive, Negative, VeryNegative, Pity, Sad, Dead, Confused }
        public MoodEnum Mood;
    }
}
