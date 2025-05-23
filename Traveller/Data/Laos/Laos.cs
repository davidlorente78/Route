﻿using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Laos
{
    public static class DataLaos
    {
        public static Country Laos = new Country('L', "Laos", new DynamicHomeConfiguration()
        {
            Show = true,
            Order = 1
        }
            )
        {
            Image = @"../img/destinations/destinationLaos.jpg",
            Destinations = LaosDestinations.GetAll(),
            BorderCrossings = LaosBorderCrossings.GetAll(),
            Airports = LaosAirports.GetAll(),
            Ranges = LaosRanges.GetAll(),
            Visas = new List<Visa> { LaosVisas.LaoVisa, LaosVisas.eLaoVisa }
        };
    }
}

