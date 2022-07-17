using Domain.Ranges;
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
                Destinations = new List<Destination> { NepalDestinations.KTM },
                //La lista de fronteras que se especifican son los puntos de entrada a Singapore
                //El origen de la frontera es el del pais de entrada 
                //El destino es la frontera del pais al que se entra. En este caso WoodLands
                Frontiers = new List<Frontier> {

                            new Frontier {
                            Name = NepalDestinations.KTM.Name,
                            Origin = NepalDestinations.KTM,
                            Final = NepalDestinations.KTM,
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
                Destinations = new List<Destination> { SingaporeDestinations.SIN , SingaporeDestinations.WoodlandsCheckpoint },
                //La lista de fronteras que se especifican son los puntos de entrada a Singapore
                //El origen de la frontera es el del pais de entrada 
                //El destino es la frontera del pais al que se entra. En este caso WoodLands
                Frontiers = new List<Frontier> {

                            new Frontier {
                            Name = SingaporeDestinations.SIN.Name,
                            Origin = SingaporeDestinations.SIN,
                            Final = SingaporeDestinations.SIN,
                           //https://www.ica.gov.sg/
                            Visas = new List<Visa> { SingaporeVisa.SGArrivalCard } },

                            new Frontier {
                            Name = SingaporeDestinations.WoodlandsCheckpoint.Name,
                            Origin = MalaysiaDestinations.JohorBahru,
                            Final = SingaporeDestinations.WoodlandsCheckpoint,
                            Visas = new List<Visa> { SingaporeVisa.SGArrivalCard } },

                            //Frontier https://en.wikipedia.org/wiki/Malaysia%E2%80%93Singapore_Second_Link
                        },
                Visas = new List<Visa> { SingaporeVisa.SGArrivalCard } //Estas son las que salen en la pagina IndexView

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
        }
    }
}
