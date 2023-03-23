using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Cambodia
{
    public static class DataCambodia
    {
        public static Country Cambodia = new Country('C', "Cambodia", true, 2)
        {
            Destinations = CambodiaDestinations.GetAll(),
            BorderCrossings = CambodiaBorderCrossings.GetAll(),
            Airports = CambodiaAirports.GetAll(),
            Ranges = new List<RangeChar> {
                CambodiaRanges.SeasonRange,
                CambodiaRanges.MonsoonRange,
                CambodiaRanges.MonsoonRangeEvaluator
            },
        };
    }
}

