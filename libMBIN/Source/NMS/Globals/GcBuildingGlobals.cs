﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x1F6E0B85A9ECF7CC)]
    public class GcBuildingGlobals : NMSTemplate
    {
        /* 0x0 */ public float Unknown0x0;
        /* 0x4 */ public float Unknown0x4;
        /* 0x8 */ public float Unknown0x8;
        /* 0xC */ public float Unknown0xC;
        /* 0x10 */ public float Unknown0x10;
        /* 0x14 */ public float Unknown0x14;
        /* 0x18 */ public float Unknown0x18;
        /* 0x1C */ public float Unknown0x1C;
        /* 0x20 */ public float Unknown0x20;
        /* 0x24 */ public float Unknown0x24;
        /* 0x28 */ public float Unknown0x28;
        /* 0x2C */ public float Unknown0x2C;
        /* 0x30 */ public float Unknown0x30;
        /* 0x34 */ public TkLODDistances Unknown0x34;
        /* 0x48 */ public TkLODDistances Unknown0x48;
        /* 0x5C */ public TkLODDistances Unknown0x5C;
        /* 0x70 */ public TkLODDistances Unknown0x70;
        /* 0x84 */ public TkLODDistances Unknown0x84;
        /* 0x98 */ public TkLODDistances Unknown0x98;
        /* 0xAC */ public TkLODDistances Unknown0xAC;
        /* 0xC0 */ public TkLODDistances Unknown0xC0;
        /* 0xD4 */ public float Unknown0xD4;
        /* 0xD8 */ public float Unknown0xD8;
        /* 0xDC */ public float Unknown0xDC;
        /* 0xE0 */ public bool Unknown0xE0;
        /* 0xE4 */ public float Unknown0xE4;
        /* 0xE8 */ public float Unknown0xE8;
        /* 0xEC */ public float Unknown0xEC;
        /* 0xF0 */ public float Unknown0xF0;
        /* 0xF4 */ public float Unknown0xF4;
        /* 0xF8 */ public float Unknown0xF8;
        /* 0xFC */ public float Unknown0xFC;
        /* 0x100 */ public float Unknown0x100;
        /* 0x104 */ public float Unknown0x104;
        /* 0x108 */ public float Unknown0x108;
        /* 0x10C */ public int BuildingLineCount;
        /* 0x110 */ public float IconSpringTime;

        /* 0x114 */ public float HoverFadeAlpha;
        /* 0x118 */ public float HoverTime;
        /* 0x11C */ public float HoverVisibilityTime;
        /* 0x120 */ public float HoverFadeTime;
        /* 0x124 */ public float HoverMinToStayActiveTime;
        /* 0x128 */ public float HoverStayActiveTime;
        /* 0x12C */ public float HoverLockedInitTime;
        /* 0x130 */ public float HoverLockedActiveTime;
        /* 0x134 */ public float HoverLockedIconScale;
        /* 0x138 */ public float HoverInactiveSize;
        // The next block has the exact same values as the above block. VR versions maybe??
        /* 0x13C */ public float HoverFadeAlpha2;
        /* 0x140 */ public float HoverTime2;
        /* 0x144 */ public float HoverVisibilityTime2;
        /* 0x148 */ public float HoverFadeTime2;
        /* 0x14C */ public float HoverMinToStayActiveTime2;
        /* 0x150 */ public float HoverStayActiveTime2;
        /* 0x154 */ public float HoverLockedInitTime2;
        /* 0x158 */ public float HoverLockedActiveTime2;
        /* 0x15C */ public float HoverLockedIconScale2;
        /* 0x160 */ public float HoverInactiveSize2;

        /* 0x164 */ public float LineMinDistance;
        /* 0x168 */ public float LineDistanceRange;
        /* 0x16C */ public float MaxLineLength;
        /* 0x170 */ public float MinLineLength;
        /* 0x174 */ public TkCurveType LineCurve;
        /* 0x178 */ public float BuildingYOffset;
        /* 0x17C */ public float InteractMarkerYOffset;
        /* 0x180 */ public float MinRadius;
        /* 0x184 */ public float FadeRadius;
        /* 0x188 */ public float CloseFadeRadius;
        /* 0x18C */ public float CloseScaleRadius;
        /* 0x190 */ public float PlanetSectorSize;
        /* 0x194 */ public float ChanceOfAddingShelter;
        /* 0x198 */ public float SectorMessageReshowDistance;
        /* 0x19C */ public float SectorMessageCenterDistance;
        /* 0x1A0 */ public float SectorMessageMinTime;
        /* 0x1A4 */ public float MinTimeBetweenBuildingEntryMessage;
        /* 0x1A8 */ public float FadeStart;
        /* 0x1AC */ public float FadeDistance;
        /* 0x1B0 */ public float NearMinAlpha;
        /* 0x1B4 */ public float MinAlpha;
        /* 0x1B8 */ public float LineScaleFactor;
        /* 0x1BC */ public float BuildingNearDistance;
        /* 0x1C0 */ public float BuildingNearArcDistance;
        /* 0x1C4 */ public float BuildingVisitDistance;
        /* 0x1C8 */ public float NearMaxLineLength;
        /* 0x1CC */ public float NearMinLineLength;
        /* 0x1D0 */ public float NearLineScaleFactor;
        /* 0x1D4 */ public float MinElevatedHeight;
        /* 0x1D8 */ public float MaxLowHeight;
        /* 0x1DC */ public float TextStringXOffset;
        /* 0x1E0 */ public float TextTagXOffset;
        /* 0x1E4 */ public float TextTagYOffset;
        /* 0x1E8 */ public float TextTagWidthOffset;
        /* 0x1EC */ public float DistanceTextXOffset;
        /* 0x1F0 */ public float DistanceTagXOffset;
        /* 0x1F4 */ public float TextTagLength;
        /* 0x1F8 */ public float DistanceForVisited;
        /* 0x1FC */ public float DistanceForTooltip;
        /* 0x200 */ public float SmallIconSize;
        /* 0x204 */ public float LargeIconSize;
        /* 0x208 */ public float LargeIconArrowOffset;
        /* 0x20C */ public float CompassIconSize;
        /* 0x210 */ public float SmallIconArrowOffset;
        /* 0x214 */ public float SpaceMarkerOffset;
        /* 0x218 */ public float SpaceMarkerOffsetPlanet;
        /* 0x21C */ public float SpaceMarkerOffsetSamePlanet;
        /* 0x220 */ public float MarkerLineWidth;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x224 */ public byte[] Padding224;
        /* 0x230 */ public Colour MarkerLineColour;
        /* 0x240 */ public float AmountToMoveMarkerRoundSphere;
        /* 0x244 */ public float MarkerTransitionDistance;
        /* 0x248 */ public float SpaceMarkerMinHeight;
        /* 0x24C */ public float SpaceMarkerMaxHeight;
        /* 0x250 */ public float MaxTimeBetweenEvents;
        /* 0x254 */ public float ShowTimeNotDistance;
        /* 0x258 */ public float UnknownBuildingRange;
        /* 0x25C */ public float MaxIconRange;
        /* 0x260 */ public float MarkerTimeIncrease;
        /* 0x264 */ public float FlyingBuildingIconTime;
        /* 0x268 */ public int MinShipScanBuildings;
        /* 0x26C */ public int MaxShipScanBuildings;
        /* 0x270 */ public float MinRadiusForBases;
        /* 0x274 */ public float BaseRadiusExtension;
        /* 0x278 */ public float MaxRadiusForBases;
        /* 0x27C */ public float Unknown0x27C;          // possibly BuildingPlacementMaxDistance
        /* 0x280 */ public float Unknown0x280;
        /* 0x284 */ public float Unknown0x284;
        /* 0x288 */ public float Unknown0x288;
        /* 0x28C */ public float Unknown0x28C;
        /* 0x290 */ public float Unknown0x290;
        /* 0x294 */ public float Unknown0x294;
        /* 0x298 */ public float Unknown0x298;
        /* 0x29C */ public float Unknown0x29C;
        /* 0x2A0 */ public float Unknown0x2A0;
        /* 0x2A4 */ public float Unknown0x2A4;
        /* 0x2A8 */ public float Unknown0x2A8;
        /* 0x2AC */ public float Unknown0x2AC;
        /* 0x2B0 */ public int UnknownInt0x2B0;
        /* 0x2B4 */ public float Unknown0x2B4;
        /* 0x2B8 */ public float Unknown0x2B8;
        /* 0x2BC */ public float Unknown0x2BC;
        /* 0x2C0 */ public float Unknown0x2C0;
        /* 0x2C4 */ public float Unknown0x2C4;
        /* 0x2C8 */ public float Unknown0x2C8;
        /* 0x2CC */ public bool Unknown0x2CC;
        /* 0x2D0 */ public float Unknown0x2D0;
        /* 0x2D4 */ public float Unknown0x2D4;
        /* 0x2D8 */ public float Unknown0x2D8;
        /* 0x2DC */ public float Unknown0x2DC;
        /* 0x2E0 */ public float Unknown0x2E0;
        /* 0x2E4 */ public float Unknown0x2E4;
        /* 0x2E8 */ public float Unknown0x2E8;
        /* 0x2EC */ public float Unknown0x2EC;
        /* 0x2F0 */ public float Unknown0x2F0;
        /* 0x2F4 */ public float Unknown0x2F4;
        /* 0x2F8 */ public float Unknown0x2F8;
        /* 0x2FC */ public float Unknown0x2FC;
        /* 0x300 */ public float Unknown0x300;
        /* 0x304 */ public float StartCrashSiteMinDistance;
        /* 0x308 */ public float StartCrashSiteMaxDistance;
        /* 0x30C */ public float StartShelterMinDistance;
        /* 0x310 */ public float StartShelterMaxDistance;
        [NMS(Size = 0x80)]
        /* 0x314 */ public string FreighterBaseSpawnOverride;
        /* 0x394 */ public bool BaseBuildingTerrainEditBoundsOverride;
        /* 0x398 */ public float BaseBuildingTerrainEditBaseYOffset;
        /* 0x39C */ public float BaseBuildingTerrainEditTopYOffset;
        /* 0x3A0 */ public float BaseBuildingTerrainEditBoundsScalar;
        /* 0x3A4 */ public bool Unknown0x3A4;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x3A5 */ public byte[] EndPadding;
    }
}
