using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Nepal
{
    public static class SingaporeAirports
    {

        public static Airport SIN = new Airport
        {
            Name = "Singapore Changi Airport",
            IATACode = "SIN",
            ICAOCode = "WSSS",
            AirportType = AirportTypes.International
        };


    public static ICollection<Airport> GetAll()
        {


            return new List<Airport>
            {
                SIN
            };

        }
    }


}
