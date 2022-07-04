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


            Country Laos = new Country
            {
                Code = 'L',
                Name = "Laos",                
                Destinations = LaosDestinations.GetAll(), 
                Frontiers = LaosFrontiers.Frontiers,// new List<Destination> { LaosDestinations.LPQ, LaosDestinations.VTE, LaosDestinations.Savannakhet , LaosDestinations.Namkan, LaosDestinations.LuangPrabang, LaosDestinations.Taichang, LaosDestinations.Taichang},
                //Visas = new List<Visa> { LaosVisas.eLaoVisa, LaosVisas.LaoVisa }
            };

            context.Countries.Add(Laos);

            //context.SaveChanges();


            #region Other Countries
            Country Vietnam = new Country
            {
                Code = 'V',
                Name = "Vietnam",
                Destinations = new List<Destination> { VietnamDestinations.VingXuong, VietnamDestinations.Hanoi, VietnamDestinations.MocBai, VietnamDestinations.HaTien, VietnamDestinations.TayTrang, VietnamDestinations.NhapCanh },
                Frontiers = VietnamFrontiers.Frontiers

            };


            context.Countries.Add(Vietnam);

            //context.SaveChanges();

            Country Thailand = new Country
            {
                Code = 'T',
                Name = "Thailand",

                Destinations = new List<Destination> { ThailandDestinations.BKK, ThailandDestinations.Mukdahan, ThailandDestinations.NongKhai, ThailandDestinations.PadangPesar, ThailandDestinations.SungaiKolok },
                Frontiers = new List<Frontier> {

                    new Frontier {
                        Name = "Thailand Laos Frienship Bridge I ",
                        Origin = LaosDestinations.Vientiane,
                        Final = ThailandDestinations.NongKhai,
                        Type = "T",
                      //,
                        //Visas = new List<Visa> { new Visa { Duration = 15 } } ,

                        }

                         ,

                     new Frontier {
                        Name = "Thailand Laos Frienship Bridge II ",
                        Origin = ThailandDestinations.Mukdahan,
                        Final = LaosDestinations.Savannakhet,
                        Type = "T",
                        //,
                        //Visas = new List<Visa> { new Visa { Duration = 15 } } ,

                        }

                         ,

                      new Frontier {
                        Name = "Padang Pesar - Padang Pesar (Pekan Siam)",
                        Origin = MalasiaDestinations.PadangPesar,
                        Final = ThailandDestinations.PadangPesar,
                        Type = "T",
                       //,
                        //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

                        }

                         ,

                        new Frontier {
                        Name = "Sungai Kolok - Rantan Panjang",
                        Origin = MalasiaDestinations.RantanPanjang,
                        Final = ThailandDestinations.SungaiKolok,
                        Type = "T",
                       //,
                        //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

                        }

                         ,

                }
            };

            context.Countries.Add(Thailand);

            //context.SaveChanges();

            Country Malaysia = new Country
            {
                Code = 'M',
                Name = "Malaysia",
                Destinations = new List<Destination> { MalasiaDestinations.KualaLumpur, MalasiaDestinations.RantanPanjang, MalasiaDestinations.PadangPesar, MalasiaDestinations.KualaLumpur, MalasiaDestinations.Penang, MalasiaDestinations.Butterworth, MalasiaDestinations.KotaBahru, MalasiaDestinations.KUL },
                Frontiers = new List<Frontier> {


                            new Frontier {
                            Name = MalasiaDestinations.KUL.Name,
                            Origin = MalasiaDestinations.KUL,
                            Final = MalasiaDestinations.KUL,
                           //,
                        //Visas = new List<Visa> { MalasiaVisas.freeVisa ,

                        }

                         ,
                            new Frontier {
                            Name = "Padang Pesar",
                            Origin = MalasiaDestinations.PadangPesar,
                            Final = ThailandDestinations.PadangPesar,
                             }

                         ,

                            new Frontier {
                            Name = "Sungai Kolok - Rantan Panjang",
                            Origin = MalasiaDestinations.RantanPanjang,
                            Final = ThailandDestinations.SungaiKolok,
                            }

                         ,

                    }


            };

            context.Countries.Add(Malaysia);

            //context.SaveChanges();


            Country Cambodia = new Country
            {
                Code = 'C',
                Name = "Cambodia",
                Destinations = CambodiaDestinations.GetAll(),
                Frontiers = CambodiaFrontiers.Frontiers



            };

            context.Countries.Add(Cambodia);

            context.SaveChanges();
            #endregion
        }
    }
}
