using Data.Cambodia;
using Data.EntityTypes;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaBorderCrossings
    {


        public static List<BorderCrossing> GetAll()

        {
            List<BorderCrossing> terrestrial = GetAllTerrestrialFrontiers();

            List<BorderCrossing> frontiersFromAirports = CreateFrontiersFromInternationalAirports();

            terrestrial.AddRange(frontiersFromAirports);

            return terrestrial;

        }

        public static List<BorderCrossing> CreateFrontiersFromInternationalAirports()
        {
            List<BorderCrossing> frontiers = new List<BorderCrossing>();


            var airports = CambodiaAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {

                BorderCrossing frontierFromAirport = new BorderCrossing()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    Origin = airport.Destinations.FirstOrDefault(),
                    Final = airport.Destinations.FirstOrDefault(),
                    BorderCrossingType = BorderCrossingTypes.Airport,
                    Visas = new List<Visa> { CambodiaVisas.eVisa_Cambodia },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }




        public static List<BorderCrossing> GetAllTerrestrialFrontiers()
        {
            return new List<BorderCrossing> {
                //Poi Pet(Banteay Meanchey)  Tailandia Sí  Sí
                //Banteay Meanchey es la provincia Camboyana
                new BorderCrossing {
                        Name = "Poipet",
                        Origin = ThailandDestinations.Aranyaprathet,
                        Final = CambodiaDestinations.Poipet,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,

                        },

                  //Cham Yeam(Koh Kong)    Tailandia Sí  Sí
                  new BorderCrossing {
                        Name = "Cham Yeam Border Check Point",
                        Origin = ThailandDestinations.BanHatLek, //Trat Province
                        Final = CambodiaDestinations.ChamYeam,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,

                        },

                  //Chorm(Oddar Meanchey)  Tailandia No  Sí
                  //Daung(Kamrieng Battambang) Tailandia No  Sí

                  //Prom(Pailin)   Tailandia No  Sí
                  //Ban Pakard/Phsa Prum
                  new BorderCrossing {
                        Name = "Ban Pakkad (Ban Pakard) Border Checkpoint (Thailand)",
                        Origin = ThailandDestinations.KhlongYai, //Ban Pakkad Border Checkpoint  WFGV+H9P, Khlong Yai, Pong Nam Ron District, Chanthaburi 22140, Tailandia
                        Final = CambodiaDestinations.Prom,
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                        Description = "This smaller, quieter crossing is not frequently used by tourists but you may find it handy if you find yourself in the area. On the Thai side, it is close to Chanthaburi, about an hour’s drive away, and Koh Chang, which is about two hours away. The unremarkable town of Pailin is about half an hour’s drive away on the Cambodian side. Realistically, it’s likely that other border crossings will be more convenient, however here they do issue visas on arrival."
                        },

                  //O Smach(Oddar Meanchey)    Tailandia No  Sí
                  //Chong Chom border crossing

                  //Bavet(Svay Rieng)  Vietnam Sí  Sí
                    new BorderCrossing {
                        Name = "Bavet Border Checkpoint (Thailand)",
                        Origin = VietnamDestinations.MocBai, //Cửa Khẩu Mộc Bài
                        Final = CambodiaDestinations.Bavet, //ប៉ុស្ដិ៍ព្រំដែនបាវិត
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                        },

                    //Kaoam Samnor(Kandal Mekong)    Vietnam No  Sí
                    //K'am Samnar Border Crossing Station
                     new BorderCrossing {
                        Name = "Kaoam Samnor Border Checkpoint (K'am Samnar)",
                        Origin = VietnamDestinations.ThuongPhuoc , //Thuong Phuoc Gate
                        Final = CambodiaDestinations.KamSamnar, //ច្រកទ្វារព្រំដែនអន្តរជាតិក្អមសំណរ
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                        },

                    //Phnom Den(Takeo)   Vietnam No  Sí
                    //Trapaing Sre(Kratie)   Vietnam No  Sí
                    //Dong Kralo(Stung Treng)    Laos No  Sí
                    //Tropaeng Kreal Border Post(Stung Treng)    Laos Sí  Sí
                      new BorderCrossing {
                        Name = "Tropaeng Kreal Border Post",
                        Origin = LaosDestinations.NongNokKhiene , 
                        Final = CambodiaDestinations.TropaengKreal, 
                        BorderCrossingType = BorderCrossingTypes.Terrestrial,
                         Description = "This land border crossing is called Nong Nok Khiene on the Laos side and Tropaeng Kreal on the Cambodia side. The Cambodian province of Stung Treng borders the 4,000 Islands area of southern Laos."
                        },
                     

                 };

            
        }


    }
}
