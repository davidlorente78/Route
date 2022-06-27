using System.Collections.Generic;

namespace Traveller.Data
{
    public static class LaosFrontiers
    {
        public static List<Frontier> Frontiers = new List<Frontier> {

                    new Frontier {
                        Name = "Thailand Laos Frienship Bridge I ",

                        Origin = ThailandDestinations.NongKhai,
                        TransitDestination = LaosDestinations.Vientiane,
                        Type = "T",
                        Visas = new List<Visa> { { LaosVisas.eLaoVisa
                            }
                        }
                    }   ,


                       new Frontier
                    {
                        Name = "Tay Trang Border Crossing Station",
                        Description = LaosDestinations.Taichang.Description,
                        Origin = VietnamDestinations.TayTrang,
                        Destination = LaosDestinations.Taichang,

                        TransitOrigin = VietnamDestinations.Hanoi,
                        TransitDestination = LaosDestinations.Vientiane,
                        Type = "T",
                        Transit = true,
                        Transport = "B",
                        Visas = new List<Visa> { { LaosVisas.LaoVisa } }
                    },

                      new Frontier
                      {   //http://lamochilainquieta.com/hanoi-laos-autobus/
                          //F39P+MQ Kỳ Sơn District, Nghe An, Vietnam
                          Name = LaosDestinations.Namkan.Name,
                          Description = LaosDestinations.Namkan.Description,
                          Transit = true,
                          Transport = "B",
                          Origin = VietnamDestinations.NhapCanh,
                          Destination = LaosDestinations.Namkan,
                          TransitOrigin = VietnamDestinations.Hanoi,
                          TransitDestination = LaosDestinations.LuangPrabang,
                          Type = "T",
                          Visas = new List<Visa> { { LaosVisas.LaoVisa } }
                      },
                    new Frontier
                    {
                        Name = LaosDestinations.VTE.Name,
                          Origin = new Destination { Code = "A", CountryCode = 'A'}, //International Airport
                        Destination = LaosDestinations.VTE,
                        Type = "A",
                        Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
                    },
                    new Frontier
                    {
                        Name = LaosDestinations.LPQ.Name,
                        Origin = new Destination { Code = "A", CountryCode = 'A'}, //International Airport
                        Destination = LaosDestinations.LPQ,
                        Type = "A",
                        Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
                    } ,

                    new Frontier
                    {
                        Name = "Thailand Laos Frienship Bridge II ",
                        Description = "Bridge over the Mekong that connects Mukdahan Province in Thailand with Savannakhet in Laos",
                        Origin = ThailandDestinations.Mukdahan,
                        Destination = LaosDestinations.Savannakhet,
                        Type = "T",
                        Visas = new List<Visa> { { LaosVisas.eLaoVisa } }
                    }

                    //Lao Bao Pass: Es el borde fronterizo más popular, si bien estaba demasiado al Sur como para resultarnos de interés. Queda muy cerca de Hué.
    };

    }
}
