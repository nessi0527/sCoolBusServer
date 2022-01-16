﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class StationDriverDTO:Profile
    {
        public int DriverId { get; set; }
        public int StationId { get; set; }

        public string Address { get; set; }

        public double PointX { get; set; }

        public double PointY { get; set; }

    }
}
