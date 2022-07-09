using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosFrontiers
    {

        public static Frontier VTE = new Frontier
        {
            Name = LaosDestinations.VTE.Name,
            Description = LaosDestinations.VTE.Description,
            Origin = LaosDestinations.VTE,
            Final = LaosDestinations.VTE,
            Type = "A", //Airport
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };

        public static Frontier LPQ = new Frontier
        {
            Name = LaosDestinations.LPQ.Name,
            Description = LaosDestinations.LPQ.Description,
            Origin = LaosDestinations.LPQ,
            Final = LaosDestinations.LPQ,
            Type = "A",
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };

        public static Frontier Frienship_Bridge_I = new Frontier
        {
            Name = "Thailand Laos Frienship Bridge I",

            Origin = ThailandDestinations.NongKhai,
            Final = LaosDestinations.Vientiane,
            Type = "T", //Terrestrial
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };

        public static Frontier PAK = new Frontier
        {
            Name = "Pakse International Airport (Champasack Province)",
            Origin = LaosDestinations.PAK,
            Final = LaosDestinations.PAK,
            Type = "T",
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };

       

        public static Frontier Frienship_Bridge_II = new Frontier
        {
            Name = "Thailand Laos Frienship Bridge II",
            Description = "Bridge over the Mekong that connects Mukdahan Province in Thailand with Savannakhet in Laos",
            Origin = ThailandDestinations.Mukdahan,
            Final = LaosDestinations.Savannakhet,
            Type = "T",
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };


        public static Frontier ChiangKhongHuayXai = new Frontier
        {
            Name = "Thailand Laos Chiang Khong - Huay Xai",
            Origin = ThailandDestinations.ChiangKhong,
            Final = LaosDestinations.HuayXai,
            Description = "No acepta visado electronico pero permite hacer la travesia del Mekong hacia Luang Prabang en sentido único y descendente",
            Type = "T",
            Visas = new List<Visa> { { LaosVisas.LaoVisa } }

        };


        public static Frontier ChongMekVangTao = new Frontier
        {
            Name = "Chong Mek - Vang Tao",
            Origin = ThailandDestinations.VangTao,
            Final = LaosDestinations.ChongMek,
            Type = "T"
        };


        public static Frontier TayTrangTaichang = new Frontier {
            Name = "Laos Vietnam  Sop Hun Tay Trang ",
            Description = "Usado por autobuses que van desde Vientiane hacia Hanoi y viceversa. Tambien es posible utilizarlo si se va o viene de Sapa (Vietnam)",
            Origin = VietnamDestinations.TayTrang,
            Final = LaosDestinations.SopHun,

            Type = "T",


        };

        public static Frontier NamkanNhapCanh =  new Frontier
                        {
                            Name = "Laos Vietnam Namkan NhapCanh ",
                            Description = "Usado por autobuses que van desde Vientiane o Luang Prabang hacia Hanoi y viceversa. Tambien es posible utilizarlo si se va o viene de Sapa (Vietnam)",
                            Origin = VietnamDestinations.NhapCanh,
                            Final = LaosDestinations.Namkan,
                            Type = "T",
                        };



        public static Frontier DansavanhLaoBao = new Frontier {
            Name = "Laos Vietnam Lao Bao Dansavanh ",
            Description = "Paso fronterizo a la altura de Hue. En la misma frontera hay autobuses que salen hacia Pakse (Laos) y  otra terminal de autobuses con destino a Savannakhet (5h)",
            Origin = VietnamDestinations.LaoBao,
            Final = LaosDestinations.Dansavanh,
            Type = "T",
            //,
            //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

        };

        public static Frontier NamPhaoCauTreo = new Frontier
        {
            Name = "Laos Vietnam Nam Phao CauTreo",
            Description = "Paso fronterizo a la altura de Vinh",
            Origin = VietnamDestinations.CauTreo,
            Final = LaosDestinations.NamPhao,
            Type = "T",
            //,
            //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

        };

                         
                         

        public static ICollection<Frontier> GetAll()
        {
            return new List<Frontier> {
                LaosFrontiers.LPQ,
                LaosFrontiers.VTE,
                LaosFrontiers.Frienship_Bridge_I,
                LaosFrontiers.Frienship_Bridge_II,
                LaosFrontiers.PAK ,
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

