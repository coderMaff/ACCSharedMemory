﻿using System;
using System.Runtime.InteropServices;

namespace AssettoCorsaSharedMemory
{
    public enum ACC_FLAG_TYPE
    {
        ACC_NO_FLAG = 0,
        ACC_BLUE_FLAG = 1,
        ACC_YELLOW_FLAG = 2,
        ACC_BLACK_FLAG = 3,
        ACC_WHITE_FLAG = 4,
        ACC_CHECKERED_FLAG = 5,
        ACC_PENALTY_FLAG = 6,
        ACC_GREEN_FLAG = 7,
        ACC_ORANGE_FLAG = 8
    }

    public enum ACC_PENALTY_TYPE
    {
        ACC_NONE = 0,
        ACC_DRIVETHROUGH_CUTTING = 1,
        ACC_STOPANDGO_10_CUTTING = 2,
        ACC_STOPANDGO_20_CUTTING = 3,
        ACC_STOPANDGO_30_CUTTING = 4,
        ACC_DISQUALIFIED_CUTTING = 5,
        ACC_REMOVEBESTLAPTIME_CUTTING = 6,
        ACC_DRIVETHROUGH_PITSPEEDING = 7,
        ACC_STOPANDGO_10_PITSPEEDING = 8,
        ACC_STOPANDGO_20_PITSPEEDING = 9,
        ACC_STOPANDGO_30_PITSPEEDING = 10,
        ACC_DISQUALIFIED_PITSPEEDING = 11,
        ACC_REMOVEBESTLAPTIME_PITSPEEDING = 12,
        ACC_DISQUALIFIED_IGNOREDMANDATORYPIT = 13,
        ACC_POSTRACETIME = 14,
        ACC_DISQUALIFIED_TROLLING = 15,
        ACC_DISQUALIFIED_PITENTRY = 16,
        ACC_DISQUALIFIED_PITEXIT = 17,
        ACC_DISQUALIFIED_WRONGWAY = 18,
        ACC_DRIVETHROUGH_IGNOREDDRIVERSTINT = 19,
        ACC_DISQUALIFIED_IGNOREDDRIVERSTINT = 20,
        ACC_DISQUALIFIED_EXCEEDEDDRIVERSTINTLIMIT = 21
    }

    public enum ACC_STATUS
    {
        ACC_OFF = 0,
        ACC_REPLAY = 1,
        ACC_LIVE = 2,
        ACC_PAUSE = 3
    }

    public enum ACC_SESSION_TYPE
    {
        ACC_UNKNOWN = -1,
        ACC_PRACTICE = 0,
        ACC_QUALIFY = 1,
        ACC_RACE = 2,
        ACC_HOTLAP = 3,
        ACC_TIME_ATTACK = 4,
        ACC_DRIFT = 5,
        ACC_DRAG = 6,
        ACC_HOTSTINT = 7,
        ACC_HOTSTINTSUPERPOLE = 8
    }

    public enum ACC_WHEELS_TYPE
    {
        ACC_FRONTLEFT = 0,
        ACC_FRONTRIGHT = 1,
        ACC_REARLEFT = 2,
        ACC_REARRIGHT = 3,
    }

    public enum ACC_TRACK_GRIP_STATUS
    {
        ACC_GREEN = 0,
        ACC_FAST = 1,
        ACC_OPTIMUM = 2,
        ACC_GREASY = 3,
        ACC_DAMP = 4,
        ACC_WET = 5,
        ACC_FLOODED = 6
  }

    public enum ACC_RAIN_INTENSITY
    {
        ACC_NO_RAIN = 0,
        ACC_DRIZZLE = 1,
        ACC_LIGHT_RAIN = 2,
        ACC_MEDIUM_RAIN = 3,
        ACC_HEAVY_RAIN = 4,
        ACC_THUNDERSTORM = 5
    }
    
    public class GraphicsEventArgs : EventArgs
    {
        public GraphicsEventArgs (Graphics graphics)
        {
            this.Graphics = graphics;
        }

        public Graphics Graphics { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Graphics
    {
        public int PacketId;
        public ACC_STATUS Status;
        public ACC_SESSION_TYPE Session;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String CurrentTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String LastTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String BestTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String Split;
        public int CompletedLaps;
        public int Position;
        public int iCurrentTime;
        public int iLastTime;
        public int iBestTime;
        public float SessionTimeLeft;
        public float DistanceTraveled;
        public int IsInPit;
        public int CurrentSectorIndex;
        public int LastSectorTime;
        public int NumberOfLaps;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TyreCompound;

        public float replayTimeMultiplier; //Not used in ACC
        
        public float NormalizedCarPosition;
        public int ActiveCars;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 180)]
        public float[,] CarCoordinates;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] CarID;

        public int PlayerCarId;

        public float PenaltyTime;
        public ACC_FLAG_TYPE Flag;
        public ACC_PENALTY_TYPE Penalty;
        public int IdealLineOn;

        public int IsInPitLane;
        public float SurfaceGrip;
    
        public int MandatoryPitDone;
        public float WindSpeed;
        public float WindDirection;
        public int IsSetupMenuVisible;
        public int MainDisplayIndex;
        public int SecondaryDisplayIndex;
        public int TC;
        public int TCUT;
        public int EngineMap;
        public int ABS;
        public float FuelXLap;
        public int RainLights;
        public int FlashingLights;
        public int LightsStage;
        public float ExhaustTemperature;
        public int WiperLV;
        public int DriverStingTotalTimeLeft;
        public int DriverStingTimeLeft;
        public int RainTyres;
        public int SessionIndex;
        public float UsedFuel; //Since last refuel
        
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String DeltaLapTime;
        public int IDeltaLapTime;
        
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String EstimatedLapTime;
        public int IEstimatedLapTime;
        
        public int IsDeltaPositive;
        public int ISplit; //Last split time in ms
        public int IsValidLap;
        public float FuelEstimatedLaps;
        
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TrackStatus;
        public int MissingMandatoryPits;

        public int directionLightsLeft;
        public int directionLightsRight;

        public int GlobalYellow;
        public int GlobalYellow1;
        public int GlobalYellow2;
        public int GlobalYellow3;
        public int GlobalWhite;
        public int GlobalGreen;
        public int GlobalChequered;
        public int GlobalRed;
        public int mfdTyreSet;
        public float mfdFuelToAdd;
        public float mfdTyrePressureLF;
        public float mfdTyrePressureRF;
        public float mfdTyrePressureLR;
        public float mfdTyrePressureRR;
        public ACC_TRACK_GRIP_STATUS trackGripStatus;
        public ACC_RAIN_INTENSITY rainIntensity;
        public ACC_RAIN_INTENSITY rainIntensityIn10min;
        public ACC_RAIN_INTENSITY rainIntensityIn30min;
        public int currentTyreSet;
        public int strategyTyreSet;
        public int gapAhead;
        public int gapBehind; 
  }
}
