using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Vietnam
{
    public static class DataVietnam
    {
        public static Country Vietnam = new Country('V', "Vietnam", true, 0)
        {
            //Visas = new List<Visa> { VietnamVisas.eVisa_Vietnam, VietnamVisas.VisaExemption_Vietnam },
            Destinations = VietnamDestinations.GetAll(),
            BorderCrossings = VietnamBorderCrossings.GetAll(),
            Airports = VietnamAirports.GetAll(),
            TrainLines = VietnamTrainLines.GetAll(),
            Ranges = new List<RangeChar> { VietnamRanges.SeasonRange, VietnamRanges.MonsoonRange, VietnamRanges.MonsoonRangeEvaluator },
        };
    }
}
