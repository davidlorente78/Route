using CURDOperationWithImageUploadCore5_Demo.Models;
using Domain.Ranges;
using StaticData;
using StaticData.Cambodia;
using StaticData.Laos;
using StaticData.Malaysia;
using StaticData.Thailand;
using StaticData.Vietnam;
using StaticData.Nepal;
using Traveller.Domain;
using Traveller.StaticData;

namespace RouteDataManager.Repositories
{
    /// <summary>
    /// Comprueba si existe la base de datos:
    ///Si no se encuentra la base de datos,
    ///se crea y se carga con datos de prueba.Carga los datos de prueba en matrices en lugar de colecciones List<T> para optimizar el rendimiento.
    ///Si la base de datos se encuentra, no se realiza ninguna acción.
    /// </summary>
    public class DbInitializer
    {
        //https://www.tiansungi.com/border-crossing-laos-cambodia/

        public DbInitializer() { }

        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureDeleted(); //
            context.Database.EnsureCreated();


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

                Frontiers = new List<Frontier> {

                            new Frontier {
                            Name = NepalAirports.KTM.Name,
                            Origin = NepalDestinations.Kathmandu,
                            Final = NepalDestinations.Kathmandu,
                            FrontierType = FrontierTypes.Airport,
                            Visas = new List<Visa> { NepalVisas.OnArrivalVisa15_Nepal, NepalVisas.OnArrivalVisa30_Nepal, NepalVisas.OnArrivalVisa90_Nepal, NepalVisas.FreeVisa_Nepal } },
                        },
                Visas = new List<Visa> { NepalVisas.OnArrivalVisa15_Nepal, NepalVisas.OnArrivalVisa30_Nepal, NepalVisas.OnArrivalVisa90_Nepal, NepalVisas.FreeVisa_Nepal }
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
                Frontiers = new List<Frontier> {

                            new Frontier {
                            Name = "Singapore Changi Airport",
                            Origin = SingaporeDestinations.Singapore,
                            Final = SingaporeDestinations.Singapore,
                            FrontierType = FrontierTypes.Airport,
                           //https://www.ica.gov.sg/
                            Visas = new List<Visa> { SingaporeVisas.SGArrivalCard_Singapore } },

                            new Frontier {
                            Name = SingaporeDestinations.WoodlandsCheckpoint.Name,
                            Origin = MalaysiaDestinations.JohorBahru,
                            Final = SingaporeDestinations.WoodlandsCheckpoint,
                            FrontierType = FrontierTypes.Terrestrial,
                            Visas = new List<Visa> { SingaporeVisas.SGArrivalCard_Singapore } },

                            //Frontier https://en.wikipedia.org/wiki/Malaysia%E2%80%93Singapore_Second_Link
                        },
                Visas = new List<Visa> { SingaporeVisas.SGArrivalCard_Singapore },//Estas son las que salen en la pagina IndexView
                Airports = new List<Airport> { SingaporeAirports.SIN},
             
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


            //context.SaveChanges();
            //#endregion


            #region DemoSepakers
            //if (!context.Speakers.Any())
            //{
            //    context.Speakers.AddRange(new List<Speaker>()
            //        {
            //            new Speaker()
            //            {
            //              SpeakerName="Jack Christiansen",
            //              Experience=5,
            //              Qualification="MSc Computer Science",
            //              SpeakingDate=DateTime.Now.AddDays(2) ,
            //              SpeakingTime=DateTime.Now.AddDays(2).AddHours(18).AddMinutes(00),
            //              ProfilePicture="/avatar.png",
            //              Venue="Bangalore"
            //            },
            //            new Speaker()
            //            {
            //              SpeakerName="Brenden Legros",
            //              Experience=7,
            //              Qualification="MBA",
            //              SpeakingDate=DateTime.Now.AddDays(2) ,
            //              SpeakingTime=DateTime.Now.AddDays(2).AddHours(20).AddMinutes(00),
            //              ProfilePicture="/avatar.png",
            //              Venue="Hyderabad"
            //            },
            //            new Speaker()
            //            {
            //              SpeakerName="Julia Adward",
            //              Experience=5,
            //              Qualification="Digital Marketing",
            //              SpeakingDate=DateTime.Now.AddDays(2) ,
            //              SpeakingTime=DateTime.Now.AddDays(2).AddHours(20).AddMinutes(00),
            //              ProfilePicture="/avatar.png",
            //              Venue="Chennai"
            //            }
            //        });
            //    context.SaveChanges();

            //}
            #endregion

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
                          MapPicture="/air-asia-routes.jpg",
                          Description="AirAsia (stylized as airasia) is a Malaysian multinational low-cost airline headquartered near Kuala Lumpur, Malaysia. It is the largest airline in Malaysia by fleet size and destinations. AirAsia operates scheduled domestic and international flights to more than 165 destinations spanning 25 countries.[4] Its main base is klia2, the low-cost carrier terminal at Kuala Lumpur International Airport (KLIA) in Sepang, Selangor, Malaysia."
                        },

                        new Airline()
                        {
                          IATACode ="TR",
                          Url = "www.flyscoot.com",
                          MainAirport = SingaporeAirports.SIN,
                          Name="Scoot",
                          MapPicture="/fly-scoot.jpg",
                          Description="Scoot Pte Ltd, operating as Scoot, is a Singaporean low-cost airline and a wholly owned subsidiary of Singapore Airlines. It began its operations on 4 June 2012 on medium and long-haul routes from Singapore, predominantly to various airports throughout the Asia-Pacific."  }
                    ,

                
                        new Airline()
                        {
                          IATACode ="DD",
                           
                          MainAirport = ThailandAirports.DMK,
                          Url ="www.nokair.com",
                          Name="Nok Air",
                          MapPicture="/nok-air-rutas.png",
                          Description="Nok Air is a low-cost airline in Thailand operating mostly domestic services out of Bangkok's Don Mueang International Airport. Nok Air also offers ferry services to domestic island destinations as well as domestic and cross border coach services to Vientiane and Pakse in Laos in conjunction with other tour operators."

                        }
                        ,
                         new Airline()
                        {
                          IATACode ="DD",

                          MainAirport = ThailandAirports.BKK,
                          Url ="bangkokair.com",
                          Name="Bangkok Airways",
                          MapPicture="/bangkok-airways-routes-map.jpg",
                          Description=" is a regional airline based in Bangkok, Thailand.[2] It operates scheduled services to destinations in Thailand, Cambodia, China, Hong Kong, India, Laos, Malaysia, Maldives, Myanmar, Singapore, and Vietnam. Its main base is Suvarnabhumi Airport."
                        }

                       ,                          
                         new Airline()
                        {
                          IATACode ="JQ",
                          //MainAirport = AustraliaAirports., //Merlbourbe
                          Url ="www.jetstar.com",
                          Name="Jet Star Airways",
                          MapPicture="/jetstar-route.jpg",
                          Description="Is an Australian low-cost airline headquartered in Melbourne.[4][5] It is a wholly owned subsidiary of Qantas, created in response to the threat posed by airline Virgin Blue. Jetstar is part of Qantas' two brand strategy[6] of having Qantas Airways for the premium full-service market and Jetstar for the low-cost market. "
                         }

                        // ,


                        // new Airline()
                        //{
                        //  IATACode ="JQ",
                        //  MainAirport =  SingaporeAirports.SIN,
                        //  Url ="www.singaporeair.com",
                        //  Name="Singapore Airlines",
                        //  MapPicture="/tiger_airways-route.png",
                        //  Description="" }


                } );


                context.SaveChanges();

            }
        

        }
    }
}


