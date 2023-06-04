using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Thailand
{
    public static class DataThailand
    {
        public static Country Thailand = new Country('T', "Thailand", true, 5)
        {
            Image = @"../img/destinations/destinationThailand.jpg",
            Destinations = ThailandDestinations.GetAll(),
            BorderCrossings = ThailandBorderCrossings.GetAll(),
            TrainLines = ThailandTrainLines.GetAll(),
            Airports = ThailandAirports.GetAll(),
            Ranges = ThailandRanges.GetAll(),
            Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand }
        };
    }
}
