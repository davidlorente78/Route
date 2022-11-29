using Data.EntityTypes;
using Data.Laos;
using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosBorderCrossings
    {

  
        public static BorderCrossing Frienship_Bridge_I = new BorderCrossing
        {
            Name = "Thailand Laos Frienship Bridge I",

            DestinationOrigin = ThailandDestinations.NongKhai,
            DestinationFinal = LaosDestinations.Vientiane,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
            Description = "With a “Friendship Bridge” separating the two countries, this border can be crossed easily using international buses, private taxis, or a tuk-tuk. You should be wary of any taxi or tuk-tuk drivers trying to take you anywhere other than the crossing itself as they are likely trying to get you to use and pay for the service of a travel agent who won’t do much more than fill out the forms for you.",

            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };

    

        public static BorderCrossing Frienship_Bridge_II = new BorderCrossing
        {
            Name = "Thailand Laos Frienship Bridge II",
            Description = "Bridge over the Mekong that connects Mukdahan Province in Thailand with Savannakhet in Laos. Located in the northeastern region known as Isaan, Mukdahan and Savannakhet are separated by a bridge spanning the mighty Mekong River (the second “Friendship Bridge”). This crossing is very popular with ex-pats and tourists due to the Thai embassy in Savannakhet, which has long been known as one of the friendlier embassies where you can obtain a new visa and then re-enter Thailand. Savannakhet, although a fairly small, dusty provincial Laos town, does have a few markets, bars, and various restaurants, as well as a casino and, will keep you busy for a day or two whilst you wait for your visa to be processed (which is an overnight process). It is about two hours from Nakhon Phanom and there are two buses an hour from Mukdahan. There is no train line to Mukdahan",

            DestinationOrigin = ThailandDestinations.Mukdahan,
            DestinationFinal = LaosDestinations.Savannakhet,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };


        public static BorderCrossing ChiangKhongHuayXai = new BorderCrossing
        {
            Name = "Thailand Laos Chiang Khong - Huay Xai",
            DestinationOrigin = ThailandDestinations.ChiangKhong,
            DestinationFinal = LaosDestinations.HuayXai,
            Description = "It does not accept electronic visa but it allows to make the crossing of the Mekong to Luang Prabang in one way and downstream.",
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
            Visas = new List<Visa> { { LaosVisas.LaoVisa } }

        };


        public static BorderCrossing ChongMekVangTao = new BorderCrossing
        {
            Name = "Chong Mek - Vang Tao",
            DestinationOrigin = ThailandDestinations.VangTao,
            DestinationFinal = LaosDestinations.ChongMek,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
        };


        public static BorderCrossing TayTrangTaichang = new BorderCrossing {
            Name = "Laos Vietnam  Sop Hun - Tay Trang ",
            Description = "Used by buses going from Vientiane to Hanoi and vice versa. It is also possible to use it if you are going to or coming from Sapa (Vietnam).",
            DestinationOrigin = VietnamDestinations.TayTrang,
            DestinationFinal = LaosDestinations.SopHun,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,


        };

        public static BorderCrossing NamkanNhapCanh =  new BorderCrossing
        {
            Name = "Laos Vietnam Namkan - Nhap Canh ",
            Description = "It is used by buses going from Vientiane or Luang Prabang to Hanoi and vice versa. It is also possible to use it if you are coming or going from Sapa (Vietnam).",
            DestinationOrigin = VietnamDestinations.NhapCanh,
            DestinationFinal = LaosDestinations.Namkan,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
        };



        public static BorderCrossing DansavanhLaoBao = new BorderCrossing {
            Name = "Laos Vietnam Lao Bao - Dansavanh ",
            Description = "Border crossing near Hue. At the same border there are buses to Pakse (Laos) and another bus terminal to Savannakhet.",
            DestinationOrigin = VietnamDestinations.LaoBao,
            DestinationFinal = LaosDestinations.Dansavanh,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
            //,
            //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

        };

        public static BorderCrossing NamPhaoCauTreo = new BorderCrossing
        {
            Name = "Laos Vietnam Nam Phao - Cau Treo",
            Description = "Border crossing point near Vinh",
            DestinationOrigin = VietnamDestinations.CauTreo,
            DestinationFinal = LaosDestinations.NamPhao,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
            //,
            //Visas = new List<Visa> { new Visa { Duration = 30 } } ,

        };

        //Tropaeng Kreal Border Post(Stung Treng)    Laos Sí  Sí
        public static BorderCrossing TropaengKreal = new BorderCrossing
        {
            Name = "Tropaeng Kreal Border Post",
            DestinationOrigin = CambodiaDestinations.TropaengKreal,
            DestinationFinal = LaosDestinations.NongNokKhiene,
            BorderCrossingType = BorderCrossingTypes.Terrestrial,
            Description = "This land border crossing is called Nong Nok Khiene on the Laos side and Tropaeng Kreal on the Cambodia side. The Cambodian province of Stung Treng borders the 4,000 Islands area of southern Laos."
        };

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


            var airports = LaosAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {

                BorderCrossing frontierFromAirport = new BorderCrossing()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    DestinationOrigin = airport.Destinations.FirstOrDefault(),
                    DestinationFinal = airport.Destinations.FirstOrDefault(),
                    BorderCrossingType = BorderCrossingTypes.Airport,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }
        public static List<BorderCrossing> GetAllTerrestrialFrontiers()
        {
            return new List<BorderCrossing> {
          
                LaosBorderCrossings.Frienship_Bridge_I,
                LaosBorderCrossings.Frienship_Bridge_II,
                LaosBorderCrossings.ChiangKhongHuayXai,
                LaosBorderCrossings.ChongMekVangTao,
                LaosBorderCrossings.NamkanNhapCanh ,
                LaosBorderCrossings.TayTrangTaichang,
                LaosBorderCrossings.DansavanhLaoBao,
                LaosBorderCrossings.NamPhaoCauTreo,



            };


        }

        //Lao Bao Pass: Es el borde fronterizo más popular, si bien estaba demasiado al Sur como para resultarnos de interés. Queda muy cerca de Hué.
    };

    }

