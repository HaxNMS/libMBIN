﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE5E21E940803790E, SubGUID = 0xA699A80ACABBB3C5)]
    public class GcPlanetWeatherColourData : NMSTemplate        // size: 0xB0
    {
        public Colour SkyColour;
        public Colour SkyUpperColour;
        public Colour SkySolarColour;
        public Colour HorizonColour;
        public Colour SunColour;
        public Colour FogColour;
        public Colour HeightFogColour;
        public Vector4f SkyGradientSpeed;
        public Colour LightColour;
        public Colour CloudColour1;
        public Colour CloudColour2;
    }
}
