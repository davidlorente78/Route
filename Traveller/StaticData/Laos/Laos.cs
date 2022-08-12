using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Laos
{
    public static class DataLaos
    {
        public static Country Laos = new Country()
        {
            Code = 'L',
            Name = "Laos",
            Destinations = LaosDestinations.GetAll(),
            Frontiers = LaosFrontiers.GetAll(),
            Airports = LaosAirports.GetAll(),
            Ranges = new List<RangeChar> { LaosRanges.SeasonRange },
            ShowInDynamicHome = true,
            ShowInDynamicHomeOrder = 1,
            Visas = new List<Visa> { LaosVisas.LaoVisa, LaosVisas.eLaoVisa },

        };


    }
}

