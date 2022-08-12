using StaticData;
using StaticData.Laos;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosFrontiers
    {

  
        public static Frontier Frienship_Bridge_I = new Frontier
        {
            Name = "Thailand Laos Frienship Bridge I",

            Origin = ThailandDestinations.NongKhai,
            Final = LaosDestinations.Vientiane,
            FrontierType = FrontierTypes.Terrestrial,
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };

    

        public static Frontier Frienship_Bridge_II = new Frontier
        {
            Name = "Thailand Laos Frienship Bridge II",
            Description = "Bridge over the Mekong that connects Mukdahan Province in Thailand with Savannakhet in Laos",
            Origin = ThailandDestinations.Mukdahan,
            Final = LaosDestinations.Savannakhet,
            FrontierType = FrontierTypes.Terrestrial,
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };


        public static Frontier ChiangKhongHuayXai = new Frontier
        {
            Name = "Thailand Laos Chiang Khong - Huay Xai",
            Origin = ThailandDestinations.ChiangKhong,
            Final = LaosDestinations.HuayXai,
            Description = "It does not accept electronic visa but it allows to make the crossing of the Mekong to Luang Prabang in one way and downstream.",
            FrontierType = FrontierTypes.Terrestrial,
            Visas = new List<Visa> { { LaosVisas.LaoVisa } }

        };


        public static Frontier ChongMekVangTao = new Frontier
        {
            Name = "Chong Mek - Vang Tao",
            Origin = ThailandDestinations.VangTao,
            Final = LaosDestinations.ChongMek,
            FrontierType = FrontierTypes.Terrestrial,
        };


        public static Frontier TayTrangTaichang = new Frontier {
            Name = "Laos Vietnam  Sop Hun - Tay Trang ",
            Description = "Used by buses going from Vientiane to Hanoi and vice versa. It is also possible to use it if you are going to or coming from Sapa (Vietnam).",
            Origin = VietnamDestinations.TayTrang,
            Final = LaosDestinations.SopHun,
            FrontierType = FrontierTypes.Terrestrial,


        };

        public static Frontier NamkanNhapCanh =  new Frontier
        {
            Name = "Laos Vietnam Namkan - Nhap Canh ",
            Description = "It is used by buses going from Vientiane or Luang Prabang to Hanoi and vice versa. It is also possible to use it if you are coming or going from Sapa (Vietnam).",
            Origin = VietnamDestinations.NhapCanh,
            Final = LaosDestinations.Namkan,
            FrontierType = FrontierTypes.Terrestrial,
        };



        public static Frontier DansavanhLaoBao = new Frontier {
            Name = "Laos Vietnam Lao Bao - Dansavanh ",
            Description = "Border crossing near Hue. At the same border there are buses to Pakse (Laos) and another bus terminal to Savannakhet.",
            Origin = VietnamDestinations.LaoBao,
            Final = LaosDestinations.Dansavanh,
            FrontierType = FrontierTypes.Terrestrial,
            //,
            //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

        };

        public static Frontier NamPhaoCauTreo = new Frontier
        {
            Name = "Laos Vietnam Nam Phao - Cau Treo",
            Description = "Border crossing point near Vinh",
            Origin = VietnamDestinations.CauTreo,
            Final = LaosDestinations.NamPhao,
            FrontierType = FrontierTypes.Terrestrial,
            //,
            //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

        };

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


            var airports = LaosAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {

                Frontier frontierFromAirport = new Frontier()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    Origin = airport.ServingDestinations.FirstOrDefault(),
                    Final = airport.ServingDestinations.FirstOrDefault(),
                    FrontierType = FrontierTypes.Airport,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }
        public static List<Frontier> GetAllTerrestrialFrontiers()
        {
            return new List<Frontier> {
          
                LaosFrontiers.Frienship_Bridge_I,
                LaosFrontiers.Frienship_Bridge_II,
                LaosFrontiers.ChiangKhongHuayXai,
                LaosFrontiers.ChongMekVangTao,
                LaosFrontiers.NamkanNhapCanh ,
                LaosFrontiers.TayTrangTaichang,
                LaosFrontiers.DansavanhLaoBao,
                LaosFrontiers.NamPhaoCauTreo,



            };


        }

        //Lao Bao Pass: Es el borde fronterizo más popular, si bien estaba demasiado al Sur como para resultarnos de interés. Queda muy cerca de Hué.
    };

    }

