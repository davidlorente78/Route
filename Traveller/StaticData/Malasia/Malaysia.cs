using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Malaysia
{
    public static class DataMalaysia
    {
        public static Country Malaysia = new Country('M', "Malaysia", true, 3)
        {
            Image = "img/destinations/destinationMalaysia.jpg",
            Destinations = MalaysiaDestinations.GetAll(),
            Airports = MalaysiaAirports.GetAll(),
            BorderCrossings = MalaysiaBorderCrossings.GetAll(),
            TrainLines = MalaysiaTrainLines.GetAll(),
            Ranges = MalaysiaRanges.GetAll(),
            Visas = new List<Visa> { MalaysiaVisas.eVisa_Malaysia, MalaysiaVisas.freeVisa_Malaysia }

        };
    }
}
