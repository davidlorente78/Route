﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Cambodia
{
    public static class CambodiaAirports
    {
        
        public static Airport REP = new Airport
        {
            Name = "Siem Reap International Airport",
            ServingDestinations = new List<Destination> { CambodiaDestinations.SiemReap },
            IATACode = "REP",
            AirportType = AirportTypes.International
        };

        public static Airport PNH = new Airport
        {
            Name = "Phnom Penh International Airport",
            ServingDestinations = new List<Destination> { CambodiaDestinations.PhnomPenh },
            IATACode = "PNH",
            AirportType = AirportTypes.International
        };

        public static Airport KOS = new Airport
        {
            Name = "Sihanoukville International Airport",
            ServingDestinations = new List<Destination> { CambodiaDestinations.Sihanoukville },
            IATACode = "KOS",
            AirportType = AirportTypes.International
        };

 
        public static ICollection<Airport> GetAll()
        {
            return new List<Airport>
            {
                REP,PNH,KOS
            };

        }
    }
}