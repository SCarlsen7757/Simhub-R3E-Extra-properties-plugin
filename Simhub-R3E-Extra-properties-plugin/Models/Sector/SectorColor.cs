﻿using Simhub_R3E_Extra_properties_plugin.Settings;
using System;

namespace Simhub_R3E_Extra_properties_plugin.Models.Sector
{
    public class SectorColor
    {
        public static System.Windows.Media.Color ColorConverter(SectorColorSettings.Colors colors, Sector.SectorTime<TimeSpan> time)
        {
            if (time.New == TimeSpan.Zero) return colors.NotRun.Color;
            if (time.New <= time.OverallBest || time.OverallBest == TimeSpan.Zero) return colors.OverallBest.Color;
            if (time.New <= time.OverallClassBest || time.OverallBest == TimeSpan.Zero) return colors.OverallClassBest.Color;
            if (time.New <= time.PersonalBest || time.OverallBest == TimeSpan.Zero) return colors.PersonalBest.Color;
            return colors.Slow.Color;
        }
    }
}
