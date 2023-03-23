using Domain.Transport.Aviation;
using Domain.Transport.Railway;

namespace RouteDataManager.Repositories.DbInitializer
{
    public static class DbInitializerUtils
    {
        public static void AddAirportsAndRailwayStationWithSameNameToDestination(ApplicationContext context)
        {
            //Algunas entidades con relacionados entre si no han podido ser introducidas antes en la base de datos

            //Ejemplo de trabajo

            //public static Destination Sukhothai = new Destination
            //{
            //    CountryID = 3,
            //    Name = "Sukhothai",
            //    LocalName = "สุโขทัย",
            //    Description = "Ancient Sukhothai was the first capital of the Sukhothai Kingdom, a long arc of territory that ran through what is today's Laos and western Thailand as far as the Malay states. The kingdom was established in 1238 by Phokhun Si Intharathit, the founder of the Phra Ruang dynasty. It was the state that eventually had the greatest influence on the later Siamese and Thai kingdoms. Traditional Thai history has it that Ramkhamhaeng the Great, the third ruler of the Phra Ruang dynasty, developed the capital at Sukhothai. He is also venerated as being the inventor of the Thai alphabet and being an all-round role model for Thailand's politics, monarchy, and religion. Sukhothai is 12 km west of the modern city of Sukhothai Thani.",
            //    //Airports = new List<Airport> { ThailandAirports.THS },
            //    //Stations = new List<Station> { ThailandTrainStations.Phitsanulok },
            //    Picture = "/Sukhothai.jpg",
            //    DestinationTypes = new List<DestinationType> { DestinationTypes.Airport, DestinationTypes.Tourism }
            //};

            //Destination ID = 111 
            //Este ID no se tiene cuando se asigna la relacion de la destination dentro de la entidad aeropuerto THS
            //var Sukhotai = context.Destinations.Where(x => x.Name == ThailandDestinations.Sukhothai.Name).FirstOrDefault();
            //Sukhotai.Airports = new List<Airport> { ThailandAirports.THS };
            //Sukhotai.Stations = new List<Station> { ThailandTrainStations.Phitsanulok };
            //context.Update(Sukhotai);

            foreach (var destination in context.Destinations)
            {
                //Buscar si existe un aeropuerto o una station que tenga como destino la destination que estamos tratando
                var airports = context.Airports
                        .Where
                        (
                            a => a.Destinations.Select(a => a.Name).Contains(destination.Name)
                        );

                var stations = context.RailwayStations
                       .Where
                       (
                           s => s.Destinations.Select(d => d.Name).Contains(destination.Name)
                        );

                foreach (Airport airport in airports)
                {
                    destination.Airports.Add(airport);
                }

                foreach (RailwayStation station in stations)
                {
                    destination.Stations.Add(station);
                }

                context.Update(destination);
            }
        }
    }
}
