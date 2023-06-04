using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Indonesia
{
    public static class DataIndonesia
    {
        public static Country Indonesia = new Country('I', "Indonesia", false, 0)
        {
            Image = @"../img/destinations/destinationIndonesia.jpg",
            //Destinations = IndonesiaDestinations.GetAll(),
            //Airports = IndonesiaAirports.GetAll(),
            //BorderCrossings = IndonesiaBorderCrossings.GetAll(),
            //TrainLines = IndonesiaTrainLines.GetAll(),
            Ranges = IndonesiaRanges.GetAll(),
            Visas = new List<Visa> { IndonesiaVisas.eVOA_Indonesia, IndonesiaVisas.FreeEntryStamp_Indonesia }

        };
    }
}
