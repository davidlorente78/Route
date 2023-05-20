using Data.Cambodia;
using Data.EntityTypes;
using Data.Laos;
using Data.Malaysia;
using Data.Nepal;
using Data.Thailand;
using Data.Vietnam;
using Domain.Ranges;
using Domain.Transport.Aviation;
using Domain.Transport.Railway;
using Traveller.Domain;
using Traveller.StaticData;

namespace RouteDataManager.Repositories.DbInitializer
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

            //Country Indonesia = new Country('I', "Indonesia", false, 0)
            //{
            //    Ranges = new List<RangeChar> { IndonesiaRanges.MonsoonRange, IndonesiaRanges.MonsoonRangeEvaluator },

            //    //Bali Lombok TODO
            //};

            //context.Countries.Add(Indonesia);

            Country Nepal = new Country('N', "Nepal", true, 4)
            {
                Destinations = new List<Destination> { NepalDestinations.Kathmandu },
                Airports = NepalAirports.GetAll(),
                Ranges = new List<RangeChar> { NepalRanges.MonsoonRange, NepalRanges.MonsoonRangeEvaluator },

                BorderCrossings = new List<BorderCrossing>
                {
                    new BorderCrossing
                    {
                    Name = NepalAirports.KTM.Name,
                    DestinationOrigin = NepalDestinations.Kathmandu,
                    DestinationFinal = NepalDestinations.Kathmandu,
                    BorderCrossingType = BorderCrossingTypes.Airport,
                    }
                }
            };

            context.Countries.Add(Nepal);

            //Country Philippines = new Country('P', "Philippines", false, 0) { };

            //context.Countries.Add(Philippines);

            Country Singapore = new Country('S', "Singapore", false, 0)
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

            context.Countries.Add(Singapore);

            //Country SriLanka = new Country('R', "Sri Lanka", false, 0);

            //context.Countries.Add(SriLanka);

            //Country China = new Country('H', "China", false, 0);

            //context.Countries.Add(China);

            context.SaveChanges();

            var MalaysiaId = context.Countries.FirstOrDefault(item => item.Code == 'M').Id;
            var VietnamId = context.Countries.FirstOrDefault(item => item.Code == 'V').Id;
            var ThailandId = context.Countries.FirstOrDefault(item => item.Code == 'T').Id;

            if (!context.RailwaySystems.Any())
            {
                context.RailwaySystems.AddRange(new List<RailwaySystem>() {

                    new RailwaySystem ()
                    {
                        CountryId = MalaysiaId,
                        Name = "Railway System Malaysia",
                        MapPicture = "/Railway System Malaysia.png",
                        Description = ""
                    },
                     new RailwaySystem ()
                        { CountryId = ThailandId,
                            Name = "Railway System Thailand",
                            MapPicture = "/Railway System Thailand.jpg",
                            Description = ""
                        }
                     ,
                     new RailwaySystem ()
                        { CountryId = VietnamId,
                            Name = "Railway System Vietnam",
                            MapPicture = "/Railway System Vietnam.jpg",
                            Description = ""
                        }
                    });

                context.SaveChanges();
            }

            var KULId = context.Airports.FirstOrDefault(item => item.IATACode == "KUL").Id;
            var SINId = context.Airports.FirstOrDefault(item => item.IATACode == "SIN").Id;
            var DMKId = context.Airports.FirstOrDefault(item => item.IATACode == "DMK").Id;
            var BKKId = context.Airports.FirstOrDefault(item => item.IATACode == "BKK").Id;

            if (!context.Airlines.Any())
            {
                context.Airlines.AddRange(new List<Airline>()
                    {
                        new Airline()
                        {
                          IATACode ="AK",
                          Url = "ww.airasia.com",
                          MainAirportID = KULId,
                          Name="Air Asia",
                          AirlineType = AirlineTypes.Budget,
                          Picture="/air-asia-routes.jpg",
                          Description="AirAsia is a Malaysian multinational low-cost airline headquartered near Kuala Lumpur, Malaysia. It is the largest airline in Malaysia by fleet size and destinations. " +
                          "AirAsia operates scheduled domestic and international flights to more than 165 destinations spanning 25 countries. Its main base is KLIA2, the low-cost carrier terminal at Kuala Lumpur International Airport (KLIA) in Sepang, Selangor, Malaysia."
                        },
                        new Airline()
                        {
                          IATACode ="TR",
                          Url = "www.flyscoot.com",
                          MainAirportID = SINId,
                          AirlineType = AirlineTypes.Budget,
                          Name="Scoot",
                          Picture="/fly-scoot.jpg",
                          Description="Scoot Pte Ltd, operating as Scoot, is a Singaporean low-cost airline and a wholly owned subsidiary of Singapore Airlines. It began its operations on 4 June 2012 on medium and long-haul routes from Singapore, predominantly to various airports throughout the Asia-Pacific."
                        },
                        new Airline()
                        {
                          IATACode ="DD",
                          MainAirportID = DMKId,
                          Url ="www.nokair.com",
                          Name="Nok Air",
                          AirlineType = AirlineTypes.Budget,
                          Picture="/nok-air-rutas.png",
                          Description="Nok Air is a low-cost airline in Thailand operating mostly domestic services out of Bangkok's Don Mueang International Airport. Nok Air also offers ferry services to domestic island destinations as well as domestic and cross border coach services to Vientiane and Pakse in Laos in conjunction with other tour operators."
                        },
                        new Airline()
                        {
                          IATACode ="DD",
                          MainAirportID = BKKId,
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
            }

            DbInitializerUtils.AddAirportsAndRailwayStationWithSameNameToDestination(context);
        }
    }
}


