using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class LaosFrontiers


    {

        public static Frontier VTE = new Frontier
        {
            Name = LaosDestinations.VTE.Name,
            Origin = LaosDestinations.VTE,
            Final = LaosDestinations.VTE,
            Type = "A",
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
            Name = "Thailand Laos Frienship Bridge I ",

            Origin = ThailandDestinations.NongKhai,
            Final = LaosDestinations.Vientiane,
            Type = "T",
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };

        public static Frontier Frienship_Bridge_II = new Frontier
        {
            Name = "Thailand Laos Frienship Bridge II ",
            Description = "Bridge over the Mekong that connects Mukdahan Province in Thailand with Savannakhet in Laos",
            Origin = ThailandDestinations.Mukdahan,
            Final = LaosDestinations.Savannakhet,
            Type = "T",
            Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
        };


        public static List<Frontier> Frontiers = new List<Frontier> {

                     Frienship_Bridge_I ,


                       new Frontier
                    {
                        Name = "Tay Trang Border Crossing Station",
                        Description = LaosDestinations.Taichang.Description,
                        Origin = VietnamDestinations.TayTrang,
                        Final = LaosDestinations.Taichang,


                        Type = "T"                       
                       // Visas = new List<Visa> { { LaosVisas.LaoVisa } }
                    },

                      new Frontier
                      {   //http://lamochilainquieta.com/hanoi-laos-autobus/
                          //F39P+MQ Kỳ Sơn District, Nghe An, Vietnam
                          Name = LaosDestinations.Namkan.Name,
                          Description = LaosDestinations.Namkan.Description,
                          Origin = VietnamDestinations.NhapCanh,
                          Final = LaosDestinations.Namkan,

                          Type = "T",
                         }

                         ,

                   VTE

                         ,
                   LPQ

                         ,

                     Frienship_Bridge_II


                         ,

            //Lao Bao Pass: Es el borde fronterizo más popular, si bien estaba demasiado al Sur como para resultarnos de interés. Queda muy cerca de Hué.
        };

    }
}
