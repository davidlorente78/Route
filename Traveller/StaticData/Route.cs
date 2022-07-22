

using Traveller.Domain;

namespace Traveller.StaticData
{
    /// <summary>
    /// En esta clase residian los datos estaticos del modelo inicial
    /// Ahora son utilizados por DBInitializer para crear un modelo en Base de datos SQL con EF 6 para Core
    /// </summary>
    public class Route
    {
        public List<Country> Countries = new List<Country>();

        public Route()
        {

            //https://www.tiansungi.com/border-crossing-laos-cambodia/



            Destination Singapore = new Destination { Name = "Singapore" };
            Destination KUL = new Destination { Name = "Kuala Lumpur Airport" };
            Destination SIN = new Destination { Name = "Singapore Changi Airport" };
            Destination HAK = new Destination { Name = "Haikou Airport" };
            Destination SungaiKolok = new Destination { Name = "Sungai Kolok" };
            Destination PadangBesar = new Destination { Name = "Padang Besar" };


            Country Laos = new Country
            {
                Name = "Laos",
                //Frontiers = LaosFrontiers.Frontiers,
                Destinations = new List<Destination> { LaosDestinations.LPQ, LaosDestinations.VTE, LaosDestinations.VTE },
                //Visas = new List<Visa> { LaosVisas.eLaoVisa, LaosVisas.LaoVisa }
            };

            Countries.Add(Laos);

            Country Vietnam = new Country
            {
                Name = "Vietnam",
                //Frontiers = VietnamFrontiers.Frontiers

            };

            Countries.Add(Vietnam);

            Country Thailand = new Country
            {
                Name = "Thailand",

                Destinations = new List<Destination> { ThailandDestinations.BKK, ThailandDestinations.Mukdahan, ThailandDestinations.NongKhai },
                //Frontiers = new List<Frontier> {

                //    new Frontier {
                //        Name = "Thailand Laos Frienship Bridge I ",
                //        Origin = LaosDestinations.Vientiane,
                //        Final = ThailandDestinations.NongKhai,
                //        Type = "T",
                //        }

                //                             ,

                //     new Frontier {
                //        Name = "Thailand Laos Frienship Bridge II ",
                //        Origin = ThailandDestinations.Mukdahan,
                //        Final = LaosDestinations.Savannakhet,
                //        Type = "T",
                //        }

                //         ,

                //     //Los aeropuertos son del Tipo A y no tienen Origen
                //        new Frontier {
                //        Origin =  ThailandDestinations.BKK,
                //        Name = ThailandDestinations.BKK.Name,
                //        Final = ThailandDestinations.BKK,
                //        Type ="A",
                //       }

                //         ,

                //        new Frontier {
                //        Name = "Padang Pesar - Padang Pesar (Pekan Siam)",
                //        Origin = MalasiaDestinations.PadangPesar,
                //        Final = new Destination {  Name = "Padang Pesar", CountryCode= 'T'},
                //        Type = "T",
                //        }

                //         ,

                //        new Frontier {
                //        Name = "Sungai Kolok - Rantan Panjang",
                //        Origin = MalasiaDestinations.RantanPanjang,
                //        Final = new Destination {  Name = "Sungai Kolok", CountryCode= 'T'},
                //        Type = "T",
                //      }

                         //,

                //}
            };


            Countries.Add(Thailand);




            Country Malaysia = new Country
            {
                  Name = "Malaysia",
            //    Frontiers = new List<Frontier> {


            //                new Frontier {
            //                Name = KUL.Name,
            //                Origin = KUL,
            //                Final = KUL,
            //               //Visas = new List<Visa> { { malasiaia.bbsa.eLaoVisa}   }
            //        }   ,

            //                new Frontier {
            //                Name = "Padang Pesar",
            //                Origin = MalasiaDestinations.PadangPesar,
            //                Final = ThailandDestinations.PadangPesar,
            //                 //Visas = new List<Visa> { { malasiaia.bbsa.eLaoVisa}   }
            //        }   ,

            //                new Frontier {
            //                Name = "Sungai Kolok - Rantan Panjang",
            //                Origin = MalasiaDestinations.RantanPanjang,
            //                Final = ThailandDestinations.SungaiKolok,
            //                  //Visas = new List<Visa> { { malasiaia.bbsa.eLaoVisa}   }
            //        }   ,


            //        }


            };





        }


    }
}
