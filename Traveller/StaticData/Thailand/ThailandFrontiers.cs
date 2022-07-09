using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Thailand
{
    public class ThailandFrontiers
    {
        public static ICollection<Frontier> GetAll()
        {
            return new List<Frontier>
            {



                new Frontier
                {
                    Name = "Thailand Laos Frienship Bridge I ",
                    Origin = LaosDestinations.Vientiane,
                    Final = ThailandDestinations.NongKhai,
                    Description = "No es posible cruzarlo andando. Servicio regular de autobuses cada 20 minutos desde las 8AM (Puente abre a las 6AM)",
                    Type = "T",
                    Visas = new List<Visa>
                    { ThailandVisas.VisaExemption
                    },

                }

                         ,

                new Frontier
                {
                    Name = "Thailand Laos Frienship Bridge II ",
                    Origin = LaosDestinations.Savannakhet,
                    Final = ThailandDestinations.Mukdahan,
                    Description = "Se encuentra a unas dos horas de Nakhon Phanom y salen dos autobuses a la hora desde Mukdahan. No hay linea de tren hasta Mukdahan",
                    Type = "T",
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },

                }

                         ,

                new Frontier
                {
                    Name = "Chiang Khong - Huay Xai",
                    Origin = LaosDestinations.HuayXai,
                    Final = ThailandDestinations.ChiangKhong,
                    Description = "",
                    Type = "T",
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },

                }

                         ,

                new Frontier
                {
                    Name = "Padang Pesar - Padang Pesar (Pekan Siam)",
                    Origin = MalasiaDestinations.PadangPesar,
                    Final = ThailandDestinations.PadangPesar,
                    Type = "T",
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },

                }

                         ,

                new Frontier
                {
                    Name = "Sungai Kolok - Rantan Panjang",
                    Origin = MalasiaDestinations.RantanPanjang,
                    Final = ThailandDestinations.SungaiKolok,
                    Type = "T",
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },
                }

                         ,

                new Frontier
                {
                    Name = "Chong Mek - Vang Tao",
                    Origin = LaosDestinations.ChongMek,
                    Final = ThailandDestinations.VangTao,
                    Type = "T",
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },
                }

                         ,



                new Frontier
                {
                    Name = "Aranyaprathet",
                    Origin = CambodiaDestinations.Poipet,
                    Final = ThailandDestinations.Aranyaprathet,
                    Type = "T",
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },
                }



            };
        }

    }
}
    
