using Data.EntityTypes;
using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Nepal
{
    public static class DataNepal
    {
        public static Country Nepal = new Country('N', "Nepal", true, 4)
        {
            Image = @"../img/destinations/destinationNepal.jpg",
            Destinations = NepalDestinations.GetStaticAll(),
            Airports = NepalAirports.GetAll(),
            Ranges = new List<RangeChar> { NepalRanges.MonsoonRange, NepalRanges.MonsoonRangeEvaluator },
            Visas = NepalVisas.GetAll(),
            BorderCrossings = new List<BorderCrossing>
                {
                    new BorderCrossing
                    {
                    Name = NepalAirports.KTM.Name,
                    DestinationOrigin = NepalDestinations.Kathmandu,
                    DestinationFinal = NepalDestinations.Kathmandu,
                    BorderCrossingType = BorderCrossingTypes.Airport,
                    }
                }
        };
    }
}
