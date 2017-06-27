﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Common
{
    public static class CoreConstants
    {
        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }

    public static class MobileCenterConstants
    {
        public const string AndroidAppId = "9b9317bd-6122-49e1-bbe2-1d7222bd11e4";
        public const string iOSAppId = "";
    }
}
