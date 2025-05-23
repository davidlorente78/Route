﻿using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Itinerary
{
    internal class DataItinerary
    {
        public static Domain.Itineraries.Itinerary Itinerary = new Domain.Itineraries.Itinerary
        {
            Name = "Best of South East Asia in 21 days",
            Description = "",
            StartMonth = 11,
            EndMonth = 12,
            ItineraryDestinations = new List<Destination>
            {
                ThailandDestinations.Bangkok,
                LaosDestinations.LuangPrabang,
                NepalDestinations.Kathmandu
            }
        };
    }
}


