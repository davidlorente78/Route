using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Thailand
{
    public static class DataThailand
    {
        public static Country Thailand = new Country('T', "Thailand", true, 5)
        {
            //Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
            Destinations = ThailandDestinations.GetAll(),
            BorderCrossings = ThailandBorderCrossings.GetAll(),
            TrainLines = ThailandTrainLines.GetAll(),
            Airports = ThailandAirports.GetAll(),
            Ranges = new List<RangeChar> { ThailandRanges.SeasonRange, ThailandRanges.MonsoonRange, ThailandRanges.MonsoonRangeEvaluator },

        };
    }
}
