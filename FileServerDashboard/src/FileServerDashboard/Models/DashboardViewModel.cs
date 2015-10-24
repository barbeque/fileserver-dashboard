﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileServerDashboard.Models
{
    public class DashboardViewModel
    {
        public float CpuUsage { get; set; }

        public float MemoryUsage { get; set; }

        public double TotalArray { get; set; }

        public double FreeArray { get; set; }

        public double UsedArray { get; set; }
    }
}
