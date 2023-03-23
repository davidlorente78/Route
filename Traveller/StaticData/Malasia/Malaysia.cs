using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Malaysia
{
    public static class DataMalaysia
    {
        public static Country Malaysia = new Country('M', "Malaysia", true, 3)
        {          
            Destinations = MalaysiaDestinations.GetAll(),
            Airports = MalaysiaAirports.GetAll(),
            BorderCrossings = MalaysiaBorderCrossings.GetAll(),
            TrainLines = MalaysiaTrainLines.GetAll(),
            Ranges = new List<RangeChar> { MalaysiaRanges.SeasonRange, MalaysiaRanges.MonsoonRange, MalaysiaRanges.MonsoonRangeEvaluator },         
        };
    }
}
