using Data.EntityTypes;
using Data.Vietnam;
using Traveller.Domain;

namespace Traveller.StaticData
{
    /// <summary>
    /// https://camboya.wordpress.com/vietnam/
    /// </summary>
    public static class VietnamBorderCrossings
    {
        public static List<BorderCrossing> GetAllTerrestrialFrontiers()
        {
            return new List<BorderCrossing> {

                    new BorderCrossing {
                        Name = "Cambodia Vietnam Bavet MocBai ",
                        Description  ="The Bavet / Moc Bai border is the most used by tourists because it allows you to connect by bus Phnom Penh with Ho Chi Minh City in the fastest and most direct way.",
                        DestinationOrigin = CambodiaDestinations.Bavet,
                        DestinationFinal = VietnamDestinations.MocBai,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                       //,
                        //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

                        }

                         ,

                       new BorderCrossing {
                        Name = "Laos Vietnam Sop Hun Tay Trang ",
                        Description  ="Used by buses going from Vientiane to Hanoi and vice versa. It is also possible to use it if you are going to or coming from Sapa (Vietnam).",
                        DestinationOrigin = LaosDestinations.SopHun,
                        DestinationFinal = VietnamDestinations.TayTrang,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,                   
                        //,
                        //Este paso no acepta visa Online

                        }

                         ,

                        new BorderCrossing {
                        Name = "Laos Vietnam Namkan NhapCanh",
                        Description  ="Used by NhapCanh going from Vientiane or Luang Prabang to Hanoi and vice versa. It is also possible to use it if you are coming or going from Sapa (Vietnam).",
                        DestinationOrigin = LaosDestinations.Namkan,
                        DestinationFinal = VietnamDestinations.NhapCanh,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                       //,
                        }

                         ,

                    new BorderCrossing {
                        Name = "Cambodia Vietnam Prek Chak Ha Tien ",
                        Description = "If your idea is to cross to Vietnam through the south of Cambodia (or vice versa) the best way is to do it through Prek Chak / Ha Tien, through this border crossing is easy to connect the southern part of Cambodia (Sihanoukville, Kampot, Kep) with destinations such as Chau Doc or Ho Chi Minh City.",
                        DestinationOrigin = CambodiaDestinations.PrekChak,
                        DestinationFinal = VietnamDestinations.HaTien,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,

                        }
                    ,
                      new BorderCrossing {
                        Name = "Laos Vietnam Lao Bao Dansavanh ",
                        Description = "Border crossing at Hue. At the same border there are buses to Pakse (Laos) and another bus terminal to Savannakhet (5h).",
                        DestinationOrigin = LaosDestinations.Dansavanh,
                        DestinationFinal = VietnamDestinations.LaoBao,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                        }
                      ,

                       new BorderCrossing 
                       {
                        Name = "Laos Vietnam Nam Phao CauTreo",
                        Description = "Border crossing point at Vinh",
                        DestinationOrigin = LaosDestinations.NamPhao,
                        DestinationFinal = VietnamDestinations.CauTreo,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                        //,
                        //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

                        }
                         ,

                    new BorderCrossing {
                        Name = "Cambodia Vietnam Kaan Samnor / Ving Xuong ",
                        Description ="Kaan Samnor / Ving Xuong is the border crossing between the natural border that is the Mekong River. This border crossing is used by those travelers who being in Phnom Penh prefer to go by boat to Vietnam and thus begin the route through the country touring the Mekong Delta.the boat route reaches the town of Chau Doc to continue to Ho Chi Minh City by bus.",
                        DestinationOrigin = CambodiaDestinations.KaanSamnor,
                        DestinationFinal = VietnamDestinations.VingXuong,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                        //Visas = new List<Visa> { new Visa { Duration = 30 } } 
                    },
                    //Kaoam Samnor(Kandal Mekong)    Vietnam No  Sí
                    //K'am Samnar Border Crossing Station
                     new BorderCrossing {
                        Name = "Thuong Phuoc Gate - Kaoam Samnor Border Checkpoint (K'am Samnar)",
                        DestinationOrigin = CambodiaDestinations.KamSamnar,
                        DestinationFinal =  VietnamDestinations.ThuongPhuoc,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,

                        },
                    
                     //   }

                     ////No Vietnam visa on arrival for those going from Laos into Vietnam - must be pre-arranged.
                     // new Frontier {
                     //   Name = "Bus from Vientiane",
                     //   Origin = LaosDestinations.Vientiane,
                     //   Final = VietnamDestinations.Hanoi,
                     //     //Visas = new List<Visa> { new Visa { Duration = 30 }

                     //     //}
                     // }
                };
        }

        public static List<BorderCrossing> CreateFrontiersFromInternationalAirports()
        {
            List<BorderCrossing> frontiers = new List<BorderCrossing>();

            var airports = VietnamAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {
                BorderCrossing frontierFromAirport = new BorderCrossing()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    DestinationOrigin = airport.Destinations.FirstOrDefault(),
                    DestinationFinal = airport.Destinations.FirstOrDefault(),
                    BorderCrossingType = BorderCrossingTypes.Airport,

                };

                frontiers.Add(frontierFromAirport);
            }

            return frontiers;
        }

        public static List<BorderCrossing> GetAll()
        {
            List<BorderCrossing> all = new List<BorderCrossing>();

            List<BorderCrossing> terrestrial = GetAllTerrestrialFrontiers();
            List<BorderCrossing> frontiersFromAirports = CreateFrontiersFromInternationalAirports();

            all.AddRange(terrestrial);
            all.AddRange(frontiersFromAirports);

            return all;
        }
    }
}


//6WFC + 7C Na Ư, Taichang, Dien Bien, Vietnam
//Tay Trang, de reciente incorporación y con poco tráfico. El acceso al mismo era complicado y largo, si bien los paisajes del Norte de Laos son los más asombrosos de todo el país. La primera ciudad tras cruzar la frontera es Lai Chau, desde donde se puede ir a Sa Pa, un lugar dónde podemos realizar multitud de excursiones por las montañas, arrozales y poblados. Era nuestro preferido en caso de animarnos a ir a Sa Pa.