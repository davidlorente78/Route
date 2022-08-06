using CURDOperationWithImageUploadCore5_Demo.Models;
using Domain.Ranges;
using StaticData;
using StaticData.Cambodia;
using StaticData.Laos;
using StaticData.Malaysia;
using StaticData.Thailand;
using StaticData.Vietnam;
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

            #region Other Countries
            //Indonesia Nepal Sri Lanka Philippines China Singapore

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
                Destinations = new List<Destination> { NepalDestinations.KTM },
                //La lista de fronteras que se especifican son los puntos de entrada a Singapore
                //El origen de la frontera es el del pais de entrada 
                //El destino es la frontera del pais al que se entra. En este caso WoodLands
                Frontiers = new List<Frontier> {

                            new Frontier {
                            Name = NepalDestinations.KTM.Name,
                            Origin = NepalDestinations.KTM,
                            Final = NepalDestinations.KTM,
                            FrontierType = FrontierTypes.Terrestrial,
                            Visas = new List<Visa> { NepalVisas.OnArrivalVisa15, NepalVisas.OnArrivalVisa30, NepalVisas.OnArrivalVisa90, NepalVisas.FreeVisa } },
                        },
                Visas = new List<Visa> { NepalVisas.OnArrivalVisa15, NepalVisas.OnArrivalVisa30, NepalVisas.OnArrivalVisa90, NepalVisas.FreeVisa }
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
                            Visas = new List<Visa> { SingaporeVisa.SGArrivalCard } },

                            new Frontier {
                            Name = SingaporeDestinations.WoodlandsCheckpoint.Name,
                            Origin = MalaysiaDestinations.JohorBahru,
                            Final = SingaporeDestinations.WoodlandsCheckpoint,
                            FrontierType = FrontierTypes.Terrestrial,
                            Visas = new List<Visa> { SingaporeVisa.SGArrivalCard } },

                            //Frontier https://en.wikipedia.org/wiki/Malaysia%E2%80%93Singapore_Second_Link
                        },
                Visas = new List<Visa> { SingaporeVisa.SGArrivalCard },//Estas son las que salen en la pagina IndexView
                Airports = new List<Airport>
                { new Airport
                    { Name = "Singapore Changi Airport",
                     IATACode ="SIN",
                     ICAOCode ="WSSS",
                     AirportType = AirportTypes.International}
                    }
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


            context.SaveChanges();
            #endregion


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
        }
    }
}
