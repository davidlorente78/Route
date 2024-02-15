using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Cambodia
{
    public static class DataCambodia
    {
        public static Country Cambodia = new Country(
            'C',
            "Cambodia",
            new DynamicHomeConfiguration()
            {
                Show = true,
                Order = 2
            }
            )
        {
            Image = @"../img/destinations/destinationCambodia.jpg",
            Destinations = CambodiaDestinations.GetAll(),
            BorderCrossings = CambodiaBorderCrossings.GetAll(),
            Airports = CambodiaAirports.GetAll(),
            Ranges = CambodiaRanges.GetAll(),
            Visas = new List<Visa> { CambodiaVisas.eVisa_Cambodia }
        };
    }
}

