using StaticData;
using StaticData.Cambodia;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaFrontiers
    {


        public static List<Frontier> GetAll()

        {
            List<Frontier> terrestrial = GetAllTerrestrialFrontiers();

            List<Frontier> frontiersFromAirports = CreateFrontiersFromInternationalAirports();

            terrestrial.AddRange(frontiersFromAirports);

            return terrestrial;

        }

        public static List<Frontier> CreateFrontiersFromInternationalAirports()
        {
            List<Frontier> frontiers = new List<Frontier>();


            var airports = CambodiaAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {

                Frontier frontierFromAirport = new Frontier()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    Origin = airport.ServingDestinations.FirstOrDefault(),
                    Final = airport.ServingDestinations.FirstOrDefault(),
                    FrontierType = FrontierTypes.Airport,
                    Visas = new List<Visa> { CambodiaVisas.eVisa_Cambodia },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }




        public static List<Frontier> GetAllTerrestrialFrontiers()
        {
            return new List<Frontier> {
                //Poi Pet(Banteay Meanchey)  Tailandia Sí  Sí
                //Banteay Meanchey es la provincia Camboyana
                new Frontier {
                        Name = "Poipet",
                        Origin = ThailandDestinations.Aranyaprathet,
                        Final = CambodiaDestinations.Poipet,
                        FrontierType = FrontierTypes.Terrestrial,

                        },

                  //Cham Yeam(Koh Kong)    Tailandia Sí  Sí
                  new Frontier {
                        Name = "Cham Yeam Border Check Point",
                        Origin = ThailandDestinations.BanHatLek, //Trat Province
                        Final = CambodiaDestinations.ChamYeam,
                        FrontierType = FrontierTypes.Terrestrial,

                        },

                  //Chorm(Oddar Meanchey)  Tailandia No  Sí
                  //Daung(Kamrieng Battambang) Tailandia No  Sí

                  //Prom(Pailin)   Tailandia No  Sí
                  new Frontier {
                        Name = "Ban Pakkad Border Checkpoint (Thailand)",
                        Origin = ThailandDestinations.KhlongYai, //Ban Pakkad Border Checkpoint  WFGV+H9P, Khlong Yai, Pong Nam Ron District, Chanthaburi 22140, Tailandia
                        Final = CambodiaDestinations.Prom,
                        FrontierType = FrontierTypes.Terrestrial,
                        },

                  //O Smach(Oddar Meanchey)    Tailandia No  Sí
                  //Chong Chom border crossing

                  //Bavet(Svay Rieng)  Vietnam Sí  Sí
                    new Frontier {
                        Name = "Bavet Border Checkpoint (Thailand)",
                        Origin = VietnamDestinations.MocBai, //Cửa Khẩu Mộc Bài
                        Final = CambodiaDestinations.Bavet, //ប៉ុស្ដិ៍ព្រំដែនបាវិត
                        FrontierType = FrontierTypes.Terrestrial,
                        },

                    //Kaoam Samnor(Kandal Mekong)    Vietnam No  Sí
                    //K'am Samnar Border Crossing Station
                     new Frontier {
                        Name = "Kaoam Samnor Border Checkpoint (K'am Samnar)",
                        Origin = VietnamDestinations.ThuongPhuoc , //Thuong Phuoc Gate
                        Final = CambodiaDestinations.KamSamnar, //ច្រកទ្វារព្រំដែនអន្តរជាតិក្អមសំណរ
                        FrontierType = FrontierTypes.Terrestrial,
                        },

                    //Phnom Den(Takeo)   Vietnam No  Sí
                    //Trapaing Sre(Kratie)   Vietnam No  Sí
                    //Dong Kralo(Stung Treng)    Laos No  Sí
                    //Tropaeng Kreal Border Post(Stung Treng)    Laos Sí  Sí

                 };

            
        }


    }
}
