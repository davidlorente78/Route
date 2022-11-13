using Domain.Transport.Aviation;
using Data.EntityTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.StaticData;

namespace Data.Nepal
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
