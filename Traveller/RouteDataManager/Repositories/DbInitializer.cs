using Domain.Ranges;
using Domain;
using Data.Cambodia;
using Data.Laos;
using Data.Malaysia;
using Data.Thailand;
using Data.Vietnam;
using Data.Nepal;
using Traveller.Domain;
using Traveller.StaticData;
using Data.Indonesia;
using Data.EntityTypes;
using Domain.Transport.Railway;
using Domain.Transport.Aviation;

namespace RouteDataManager.Repositories
{
    public class DbInitializer
    {
        //https://www.tiansungi.com/border-crossing-laos-cambodia/

        public DbInitializer() { }


        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (!context.RangeTypes.Any())
            {
                context.RangeTypes.Add(RangeTypes.TourismSeasonRangeType);
                context.RangeTypes.Add(RangeTypes.MonsoonSeasonRangeType);

            }

            if (!context.Months.Any())
            {
                context.Months.Add(new Month { Order = 1, Name = "January" });
                context.Months.Add(new Month { Order = 2, Name = "February" });
                context.Months.Add(new Month { Order = 3, Name = "March" });
                context.Months.Add(new Month { Order = 4, Name = "April" });
                context.Months.Add(new Month { Order = 5, Name = "May" });
                context.Months.Add(new Month { Order = 6, Name = "June" });
                context.Months.Add(new Month { Order = 7, Name = "July" });
                context.Months.Add(new Month { Order = 8, Name = "August" });
                context.Months.Add(new Month { Order = 9, Name = "September" });
                context.Months.Add(new Month { Order = 10, Name = "October" });
                context.Months.Add(new Month { Order = 11, Name = "November" });
                context.Months.Add(new Month { Order = 12, Name = "December" });

            }

            // Look for any countries
            if (context.Countries.Any())
            {
                return;   // DB has been seeded
            }


            context.Countries.Add(DataLaos.Laos);

            
            context.Countries.Add(DataVietnam.Vietnam);

            context.Countries.Add(DataThailand.Thailand);

            context.Countries.Add(DataMalaysia.Malaysia);

            context.Countries.Add(DataCambodia.Cambodia);

            //#region Other Countries
            ////Indonesia Nepal Sri Lanka Philippines China Singapore

            Country Indonesia = new Country
            {
                Code = 'I',
                Name = "Indonesia",
                Ranges = new List<RangeChar> { IndonesiaRanges.MonsoonRange, IndonesiaRanges.MonsoonRangeEvaluator },

                //Bali Lombok TODO

            };

            context.Countries.Add(Indonesia);

            Country Nepal = new Country
            {
                Code = 'N',
                Name = "Nepal",
                ShowInDynamicHome = true,
                ShowInDynamicHomeOrder = 4,
                Destinations = new List<Destination> { NepalDestinations.Kathmandu },
                Airports = NepalAirports.GetAll(),
                Ranges = new List<RangeChar> { NepalRanges.MonsoonRange, NepalRanges.MonsoonRangeEvaluator },

                BorderCrossings = new List<BorderCrossing> {

                            new BorderCrossing {
                            Name = NepalAirports.KTM.Name,
                            DestinationOrigin = NepalDestinations.Kathmandu,
                            DestinationFinal = NepalDestinations.Kathmandu,
                            BorderCrossingType = BorderCrossingTypes.Airport,
                            Visas = new List<Visa> { NepalVisas.OnArrivalVisa15_Nepal, NepalVisas.OnArrivalVisa30_Nepal, NepalVisas.OnArrivalVisa90_Nepal, NepalVisas.FreeVisa_Nepal } },
                        }

            //Visas = new List<Visa> { NepalVisas.OnArrivalVisa15_Nepal, NepalVisas.OnArrivalVisa30_Nepal, NepalVisas.OnArrivalVisa90_Nepal, NepalVisas.FreeVisa_Nepal }
            ,

            };

            context.Countries.Add(Nepal);

            Country Philippines = new Country
            {
                Code = 'P',
                Name = "Philippines",
            };

            context.Countries.Add(Philippines);

            Country Singapore = new Country
            {
                Code = 'S',
                Name = "Singapore",
                Destinations = new List<Destination> { SingaporeDestinations.Singapore, SingaporeDestinations.WoodlandsCheckpoint },
                //La lista de fronteras que se especifican son los puntos de entrada a Singapore
                //El origen de la frontera es el del pais de entrada 
                //El destino es la frontera del pais al que se entra. En este caso WoodLands
                BorderCrossings = new List<BorderCrossing> {

                            new BorderCrossing {
                            Name = "Singapore Changi Airport",
                            DestinationOrigin = SingaporeDestinations.Singapore,
                            DestinationFinal = SingaporeDestinations.Singapore,
                            BorderCrossingType = BorderCrossingTypes.Airport,
                           //https://www.ica.gov.sg/
                            Visas = new List<Visa> { SingaporeVisas.SGArrivalCard_Singapore } },

                            new BorderCrossing {
                            Name = SingaporeDestinations.WoodlandsCheckpoint.Name,
                            DestinationOrigin = MalaysiaDestinations.JohorBahru,
                            DestinationFinal = SingaporeDestinations.WoodlandsCheckpoint,
                            BorderCrossingType = BorderCrossingTypes.Terrestrial,
                            Visas = new List<Visa> { SingaporeVisas.SGArrivalCard_Singapore } },

                            //Frontier https://en.wikipedia.org/wiki/Malaysia%E2%80%93Singapore_Second_Link
                        },
                //Visas = new List<Visa> { SingaporeVisas.SGArrivalCard_Singapore },//Estas son las que salen en la pagina IndexView
                Airports = new List<Airport> { SingaporeAirports.SIN },

            };

            context.Countries.Add(Singapore);

            Country SriLanka = new Country
            {
                Code = 'R',
                Name = "Sri Lanka",

            };

            context.Countries.Add(SriLanka);

            Country China = new Country
            {
                Code = 'H',
                Name = "China",

            };
            context.Countries.Add(China);

            if (!context.RailwaySystems.Any())
            {
                context.RailwaySystems.AddRange(new List<RailwaySystem>()
                    {
                        new RailwaySystem()
                        {
                          Name="Railway System Malaysia",
                          MapPicture="/Railway System Malaysia.png",
                          Description=""
                        },
                        new RailwaySystem()
                        {
                          Name="Railway System Thailand",
                          MapPicture="/Railway System Thailand.jpg",
                          Description=""
                        },
                        new RailwaySystem()
                        {
                          Name="Railway System Vietnam",
                          MapPicture="/Railway System Vietnam.jpg",
                          Description=""
                        },
                          new RailwaySystem()
                        {
                          Name="Railway System Sri Lanka",
                          MapPicture="/Railway System Sri Lanka.jpg",
                          Description=""
                        },
                    });

                context.SaveChanges();
            }


            if (!context.Airlines.Any())
            {
                context.Airlines.AddRange(new List<Airline>()
                    {
                        new Airline()
                        {
                          IATACode ="AK",
                          Url = "ww.airasia.com",
                          MainAirport = MalaysiaAirports.KUL,
                          Name="Air Asia",
                          AirlineType = AirlineTypes.Budget,
                          Picture="/air-asia-routes.jpg",
                          Description="AirAsia (stylized as airasia) is a Malaysian multinational low-cost airline headquartered near Kuala Lumpur, Malaysia. It is the largest airline in Malaysia by fleet size and destinations. AirAsia operates scheduled domestic and international flights to more than 165 destinations spanning 25 countries. Its main base is KLIA2, the low-cost carrier terminal at Kuala Lumpur International Airport (KLIA) in Sepang, Selangor, Malaysia."
                        },
                        new Airline()
                        {
                          IATACode ="TR",
                          Url = "www.flyscoot.com",
                          MainAirport = SingaporeAirports.SIN,
                          AirlineType = AirlineTypes.Budget,
                          Name="Scoot",
                          Picture="/fly-scoot.jpg",
                          Description="Scoot Pte Ltd, operating as Scoot, is a Singaporean low-cost airline and a wholly owned subsidiary of Singapore Airlines. It began its operations on 4 June 2012 on medium and long-haul routes from Singapore, predominantly to various airports throughout the Asia-Pacific."
                        },
                        new Airline()
                        {
                          IATACode ="DD",

                          MainAirport = ThailandAirports.DMK,
                          Url ="www.nokair.com",
                          Name="Nok Air",
                          AirlineType = AirlineTypes.Budget,
                          Picture="/nok-air-rutas.png",
                          Description="Nok Air is a low-cost airline in Thailand operating mostly domestic services out of Bangkok's Don Mueang International Airport. Nok Air also offers ferry services to domestic island destinations as well as domestic and cross border coach services to Vientiane and Pakse in Laos in conjunction with other tour operators."
                        },
                         new Airline()
                        {
                          IATACode ="DD",
                          MainAirport = ThailandAirports.BKK,
                          Url ="bangkokair.com",
                          Name="Bangkok Airways",
                          AirlineType = AirlineTypes.Budget,
                          Picture="/bangkok-airways-routes-map.jpg",
                          Description=" is a regional airline based in Bangkok, Thailand. It operates scheduled services to destinations in Thailand, Cambodia, China, Hong Kong, India, Laos, Malaysia, Maldives, Myanmar, Singapore, and Vietnam. Its main base is Suvarnabhumi Airport."
                         },
                         new Airline()
                        {
                          IATACode ="JQ",
                          //MainAirport = AustraliaAirports., //Merlbourbe
                          Url ="www.jetstar.com",
                          Name="Jet Star Airways",
                          AirlineType = AirlineTypes.Budget,
                          Picture="/jetstar-route.jpg",
                          Description="Is an Australian low-cost airline headquartered in Melbourne. It is a wholly owned subsidiary of Qantas, created in response to the threat posed by airline Virgin Blue. Jetstar is part of Qantas' two brand strategy of having Qantas Airways for the premium full-service market and Jetstar for the low-cost market."
                         }
                });


                context.SaveChanges();


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
                            .Where(
                                a => a.Destinations.Select(a => a.Name).Contains(destination.Name)
                             );

                    var stations = context.RailwayStations
                           .Where(
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
}


