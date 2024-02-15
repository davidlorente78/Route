using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.SriLanka
{
    public static class DataSriLanka
    {
        public static Country SriLanka = new Country('S', "SriLanka", new DynamicHomeConfiguration()
        {
            Show = true,
            Order = 4
        }
            )
        {
            Image = @"../img/destinations/destinationSriLanka.jpg",
            Destinations = new List<Destination> { SriLankaDestinations.Colombo },
            Visas = new List<Visa> { SriLankaVisas.VisaExemption },
            Ranges = new List<RangeChar> { SriLankaRanges.MonsoonRange, SriLankaRanges.MonsoonRangeEvaluator },

        };
    }
}
