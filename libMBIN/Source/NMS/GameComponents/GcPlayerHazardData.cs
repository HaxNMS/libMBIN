﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBBCFC24EB018B5F3, SubGUID = 0x18642126695741B5)]
    public class GcPlayerHazardData : NMSTemplate
    {
        public float ProtectionInitialTime;
        public Vector2f ProtectionTime;
        public Vector2f DamageRate;
        public Vector2f WoundRate;
        public float RechargeInitialTime;
        public float RechargeTime;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding24;
        [NMS(Size = 0x10)]
        public string Damage;
        public bool Increases;
        public TkCurveType Curve;
        public float TriggerValue;
        public float CapValue;
        public float CriticalValue;
        public float OutputMultiplier;
        public float OutputMinAddition;
        public float OutputMaxAddition;
    }
}
