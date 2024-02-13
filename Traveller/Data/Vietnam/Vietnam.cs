using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Vietnam
{
    public static class DataVietnam
    {
        public static Country Vietnam = new Country('V', "Vietnam", true, 0)
        {
            Image = @"../img/destinations/destinationVietnam.jpg",
            Destinations = VietnamDestinations.GetAll(),
            BorderCrossings = VietnamBorderCrossings.GetAll(),
            Airports = VietnamAirports.GetAll(),
            TrainLines = VietnamTrainLines.GetAll(),
            Ranges = VietnamRanges.GetAll(),
            Visas = new List<Visa> { VietnamVisas.eVisa_Vietnam, VietnamVisas.VisaExemption_Vietnam }
        };
    }
}
