﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x30, GUID = 0x70905D32A9E74330, SubGUID = 0x89317714328CB341)]
    public class TkInteractiveSceneData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Id;
        public List<TkInteractiveControlData> Controls;
    }
}
