using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Cambodia
{
    public static class DataCambodia
    {
        public static Country Cambodia = new Country
        {
            Code = 'C',
            Name = "Cambodia",
            Destinations = CambodiaDestinations.GetAll(),
            Frontiers = CambodiaFrontiers.Frontiers,
            Ranges = new List<RangeChar> { CambodiaRanges.SeasonRange }

        };


    }
}

