﻿using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Laos
{
    public static class DataLaos
    {
        public static Country Laos = new Country()
        {
            Code = 'L',
            Name = "Laos",
            Destinations = LaosDestinations.GetAll(),
            Frontiers = LaosFrontiers.GetAll(),
            Ranges = new List<RangeChar> { LaosRanges.SeasonRange }

        };


    }
}
