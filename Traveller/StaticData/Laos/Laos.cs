using Domain.Ranges;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Laos
{
    public static class DataLaos
    {
        public static Country Laos = new Country('L',"Laos", true,1)
        {        
            Destinations = LaosDestinations.GetAll(),
            BorderCrossings = LaosBorderCrossings.GetAll(),
            Airports = LaosAirports.GetAll(),
            Ranges = LaosRanges.GetAll()  
        };
    }
}

