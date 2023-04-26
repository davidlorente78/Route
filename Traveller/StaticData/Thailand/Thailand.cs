using Domain.Transport.Railway;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Thailand
{
    public static class DataThailand
    {
        public static Country Thailand = new Country('T', "Thailand", true, 5)
        {
            Destinations = ThailandDestinations.GetAll(),
            BorderCrossings = ThailandBorderCrossings.GetAll(),
            TrainLines = ThailandTrainLines.GetAll(),
            Airports = ThailandAirports.GetAll(),
            Ranges = ThailandRanges.GetAll(),           
        };
    }
}
