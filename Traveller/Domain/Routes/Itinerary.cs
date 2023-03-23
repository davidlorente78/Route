using Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace Domain.Routes
{
    public class Itinerary : EntityWithNameAndDescription
    {
        public int StartMonth { get; set; }
        public DateTime StartDate { get; set; }
        public int EndMonth { get; set; }
        public DateTime EndDate { get; set; }

        public List<Country> ItineraryCountries { get; set; }

        public List<Destination> ItineraryDestinations { get; set; }

    }
}



