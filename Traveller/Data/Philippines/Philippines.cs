using Data.Philippines;
using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Nepal
{
    public static class DataPhilippines
    {
        public static Country Philippines = new Country('P', "Philippines", false, 0)
        {
            Image = @"../img/destinations/destinationPhilippines.jpg",
            Visas = new List<Visa> { SriLankaVisas.VisaExemption },
            Ranges = new List<RangeChar> { PhilippinesRanges.MonsoonRange, PhilippinesRanges.MonsoonRangeEvaluator },
            Destinations = PhilippinesDestinations.GetStaticAll()
        };
    }
}
