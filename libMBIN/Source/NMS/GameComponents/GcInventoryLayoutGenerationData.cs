﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA8879B14156D70FE, SubGUID = 0x7AA76AD6E14A0C29)]
    public class GcInventoryLayoutGenerationData : NMSTemplate     // size: 0x1C0
    {
        [NMS(Size = 0x1C, EnumValue = new[] { "SciSmall", "SciMedium", "SciLarge", "FgtSmall", "FgtMedium", "FgtLarge", "ShtSmall", "ShtMedium", "ShtLarge",
                                              "DrpSmall", "DrpMedium", "DrpLarge", "RoySmall", "RoyMedium", "RoyLarge", "WeaponSmall", "WeaponMedium", "WeaponLarge",
                                              "FreighterSmall", "FreighterMedium", "FreighterLarge", "VehicleSmall", "VehicleMedium", "VehicleLarge",
                                              "ChestSmall", "ChestMedium", "ChestLarge", "ChestCapsule"})]
        public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
