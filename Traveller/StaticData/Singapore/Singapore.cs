using Data.EntityTypes;
using Domain.Transport.Aviation;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Nepal
{
    public static class DataSingapore
    {
        public static Country Singapore = new Country('S', "Singapore", false, 0)
        {
            Destinations = new List<Destination> { SingaporeDestinations.Singapore, SingaporeDestinations.WoodlandsCheckpoint },
            //La lista de fronteras que se especifican son los puntos de entrada a Singapore
            //El origen de la frontera es el del pais de entrada 
            //El destino es la frontera del pais al que se entra. En este caso WoodLands
            BorderCrossings = new List<BorderCrossing>
                {
                    new BorderCrossing
                            {
                            Name = "Singapore Changi Airport",
                            DestinationOrigin = SingaporeDestinations.Singapore,
                            DestinationFinal = SingaporeDestinations.Singapore,
                            BorderCrossingType = BorderCrossingTypes.Airport,
                           //https://www.ica.gov.sg/
                            //Visas = new List<Visa> { SingaporeVisas.SGArrivalCard_Singapore}
                            },
                            new BorderCrossing
                            {
                            Name = SingaporeDestinations.WoodlandsCheckpoint.Name,
                            DestinationOrigin = MalaysiaDestinations.JohorBahru,
                            DestinationFinal = SingaporeDestinations.WoodlandsCheckpoint,
                            BorderCrossingType = BorderCrossingTypes.Terrestrial,
                            //Visas = new List<Visa>
                            //    {
                            //        SingaporeVisas.SGArrivalCard_Singapore
                            //    }
                            },

                            //Frontier https://en.wikipedia.org/wiki/Malaysia%E2%80%93Singapore_Second_Link
                },
            Airports = new List<Airport> { SingaporeAirports.SIN },
        };
    }
}
