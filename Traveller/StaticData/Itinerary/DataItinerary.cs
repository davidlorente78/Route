using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Routes;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Itinerary
{
    internal class DataItinerary
    {
        public static Domain.Routes.Itinerary Itinerary = new Domain.Routes.Itinerary
        {
            Name = "Best of South East Asia in 21 days",
            Description = "",
            StartMonth = 11,
            EndMonth = 12,
            ItineraryDestinations = new List<Destination>
            { ThailandDestinations.Bangkok,
            LaosDestinations.LuangPrabang,
            NepalDestinations.Kathmandu}



        };
    }
}


