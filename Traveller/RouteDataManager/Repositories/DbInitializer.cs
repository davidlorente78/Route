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



        private static Destination Singapore = new Destination { Name = "Singapore", CountryCode = 'G' };
        private static Destination KUL = new Destination { Name = "Kuala Lumpur Airport", CountryCode = 'M' };
        private static Destination SIN = new Destination { Name = "Singapore Changi Airport", CountryCode = 'G' };
        private static Destination HAK = new Destination { Name = "Haikou Airport", CountryCode = 'Z' };
        private static Destination SungaiKolok = new Destination { Name = "Sungai Kolok", CountryCode = 'M' };
        private static Destination PadangBesar = new Destination { Name = "Padang Besar", CountryCode = 'M' };

        public DbInitializer() { }

        public static void Initialize(CountryDbContext context)
        {
            context.Database.EnsureDeleted(); //
            context.Database.EnsureCreated();

            // Look for any countries
            if (context.Countries.Any())
            {
                return;   // DB has been seeded
            }


            Country Laos = new Country
            {
                Code = 'L',
                Name = "Laos",
                Frontiers = LaosFrontiers.Frontiers,
                Destinations = new List<Destination> { LaosDestinations.LPQ, LaosDestinations.VTE, LaosDestinations.Savannakhet },
                //Visas = new List<Visa> { LaosVisas.eLaoVisa, LaosVisas.LaoVisa }
            };

            context.Countries.Add(Laos);

            context.SaveChanges();

            Country Vietnam = new Country
            {
                Code = 'V',
                Name = "Vietnam",
                Frontiers = VietnamFrontiers.Frontiers

            };

            context.Countries.Add(Vietnam);

            context.SaveChanges();

            Country Thailand = new Country
            {
                Code = 'T',
                Name = "Thailand",

                Destinations = new List<Destination> { ThailandDestinations.BKK, ThailandDestinations.Mukdahan, ThailandDestinations.NongKhai },
                Frontiers = new List<Frontier> {

                    new Frontier {
                        Name = "Thailand Laos Frienship Bridge I ",
                        Origin = LaosDestinations.Vientiane,
                        Destination = ThailandDestinations.NongKhai,
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 15 } } }

                    ,

                     new Frontier {
                        Name = "Thailand Laos Frienship Bridge II ",
                        Origin = ThailandDestinations.Mukdahan,
                        Destination = LaosDestinations.Savannakhet,
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 15 } } } //Aqui se indica el visado que piden en Thailandia

                    ,

                     //Los aeropuertos son del Tipo A y no tienen Origen
                        new Frontier {
                        Origin = new Destination {  CountryCode = 'A'}, //International Airport
                        Name = ThailandDestinations.BKK.Name,
                        Destination = ThailandDestinations.BKK,
                        Type ="A",
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } },

                        new Frontier {
                        Name = "Padang Pesar - Padang Pesar (Pekan Siam)",
                        Origin = MalasiaDestinations.PadangPesar,
                        Destination = new Destination {  Name = "Padang Pesar", CountryCode= 'T'},
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } } ,

                        new Frontier {
                        Name = "Sungai Kolok - Rantan Panjang",
                        Origin = MalasiaDestinations.RantanPanjang,
                        Destination = new Destination {  Name = "Sungai Kolok", CountryCode= 'T'},
                        Type = "T",
                        Visas = new List<Visa> { new Visa { Duration = 30 } ,

                        } }

                }
            };

            context.Countries.Add(Thailand);

            context.SaveChanges();

            Country Malaysia = new Country
            {
                Code = 'M',
                Name = "Malaysia",
                Frontiers = new List<Frontier> {


                            new Frontier {
                            Name = KUL.Name,
                            Origin = new Destination { CountryCode = 'A'}, //International Airport
                            Destination = KUL,
                            Visas = new List<Visa>{ MalasiaVisas.freeVisa ,

                            } } ,

                            new Frontier {
                            Name = "Padang Pesar",
                            Origin = new Destination {  Name = "Padang Pesar", CountryCode= 'T'},
                            Destination = new Destination {  Name = "Padang Pesar", CountryCode= 'M'},
                            Visas = new List<Visa>{ MalasiaVisas.freeVisa ,

                            } } ,

                            new Frontier {
                            Name = "Sungai Kolok - Rantan Panjang",
                            Origin = new Destination {  Name = "Sungai Kolok", CountryCode= 'T'},
                            Destination = new Destination {  Name = "Sungai Kolok", CountryCode= 'M'},
                            Visas = new List<Visa>{ MalasiaVisas.freeVisa ,

                            } } ,


                    }


            };

            context.Countries.Add(Malaysia);

            context.SaveChanges();


            //TODO Cambodia



        }
    }
}
