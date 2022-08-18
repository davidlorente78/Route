using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Cambodia
{
    public static class DataCambodia
    {
        public static Country Cambodia = new Country
        {   Code ='C',
            Name = "Cambodia",
            Destinations = CambodiaDestinations.GetAll(),
            Frontiers = CambodiaFrontiers.GetAll(),
            Airports = CambodiaAirports.GetAll(),
            Ranges = new List<RangeChar> { CambodiaRanges.SeasonRange , CambodiaRanges.MonsoonRange},
            ShowInDynamicHome = true,
            ShowInDynamicHomeOrder = 2,
            Visas = new List<Visa>() { CambodiaVisas.eVisa_Cambodia }

        };


    }
}

