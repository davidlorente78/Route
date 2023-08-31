using Data.Cambodia;
using Data.EntityTypes;
using Data.Indonesia;
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

            context.Countries.Add(DataIndonesia.Indonesia);

            context.Countries.Add(DataNepal.Nepal);

            context.Countries.Add(DataPhilippines.Philippines);

            context.Countries.Add(DataSingapore.Singapore);

            //Country SriLanka = new Country('R', "Sri Lanka", false, 0);

            //context.Countries.Add(SriLanka);

            //Country China = new Country('H', "China", false, 0);

            //context.Countries.Add(China);

            context.SaveChanges();

            var MalaysiaId = context.Countries.FirstOrDefault(item => item.Code == 'M').Id;
            var VietnamId = context.Countries.FirstOrDefault(item => item.Code == 'V').Id;
            var ThailandId = context.Countries.FirstOrDefault(item => item.Code == 'T').Id;
            var IndonesiaId = context.Countries.FirstOrDefault(item => item.Code == 'I').Id;
            var LaosId = context.Countries.FirstOrDefault(item => item.Code == 'L').Id;


            if (!context.RailwaySystems.Any())
            {
                context.RailwaySystems.AddRange(new List<RailwaySystem>() {

                    new RailwaySystem ()
                        {
                            CountryId = MalaysiaId,
                            Name = "Railway System Malaysia",
                            MapPicture = "/Railway System Malaysia.png",
                            Description = ""
                        }
                    ,
                     new RailwaySystem ()
                        { CountryId = ThailandId,
                            Name = "Railway System Thailand",
                            MapPicture = "/Railway System Thailand.jpg",
                            Description = ""
                        }
                     ,
                     new RailwaySystem ()
                        { CountryId = IndonesiaId,
                            Name = "Railway System Indonesia",
                            MapPicture = "/Railway System Indonesia.png",
                            Description = ""
                        }
                        ,
                     //When fully operational there will be 10 stations where passengers can board and disembark - in Vientiane, Phonhong, Vang Vieng, Kasi, Luang Prabang, Muang Nga, Muang Xay (Oudom Xay), Namor, Natuey and Boten.
                     new RailwaySystem ()
                        { CountryId = LaosId,
                            Name = "Railway System Laos",
                            MapPicture = "/Railway System Laos.png",
                            Description = "The Lao-China Railway (the Project) is a new 422 kilometer-long railway line in Lao PDR extending from the border with China near Boten to Vientiane capital city near the border with Thailand. This Project is actually only one section of a larger plan to link Kunming in China to Singapore by modern high-speed rail lines. The Project is a major achievement for the government of Lao PDR.The Project was promoted, designed and largely financed by the People's Republic of China as part of its Belt and Road Initiative. The project is managed by The Laos-China Railway Company Ltd. (the Company). Total cost was projected at just under US $6 billion. The Project is planned to have 33 railway stations in total of which 20 or 21 will be operational in the first phase with 12 to be placed into service later.In normal operation passenger trains will operate in daytime while freight trains will run at night.The Project has designated 5 stations as major stations - at Boten, Muang Xai(Oudom Xay), Luang Prabang, Vang Vieng and Vientiane.When fully operational there will be 10 stations where passengers can board and disembark - in Vientiane, Phonhong, Vang Vieng, Kasi, Luang Prabang, Muang Nga, Muang Xay(Oudom Xay), Namor, Natuey and Boten."
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


