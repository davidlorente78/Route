﻿using Domain;
using Domain.Ranges;
using StaticData.Malaysia;
using StaticData.Thailand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Vietnam
{
 
        public static class DataMalaysia
    {
        public static Country Malaysia = new Country
        {
            Code = 'M',
            Name = "Malaysia",
            Destinations = MalaysiaDestinations.GetAll(),
            Frontiers = MalaysiaFrontiers.GetAll(),
            TrainLines = MalaysiaTrainLines.GetAll(),
            Ranges = new List<RangeChar> { MalaysiaRanges.SeasonRange }

        };
    }
    
}