using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Thailand
{
    public class ThailandFrontiers
    {
        public static List<Frontier> GetAllTerrestrialFrontiers()
        {
            return new List<Frontier>
            {
                new Frontier
                {
                    Name = "Thailand Laos Frienship Bridge I ",
                    Origin = LaosDestinations.Vientiane,
                    Final = ThailandDestinations.NongKhai,
                    Description = "No es posible cruzarlo andando. Servicio regular de autobuses cada 20 minutos desde las 8AM (Puente abre a las 6AM)",
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa>
                    { ThailandVisas.VisaExemption_Thailand
                    },

                }

                         ,

                new Frontier
                {
                    Name = "Thailand Laos Frienship Bridge II ",
                    Origin = LaosDestinations.Savannakhet,
                    Final = ThailandDestinations.Mukdahan,
                    Description = "Se encuentra a unas dos horas de Nakhon Phanom y salen dos autobuses a la hora desde Mukdahan. No hay linea de tren hasta Mukdahan",
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },

                }

                         ,

                new Frontier
                {
                    Name = "Chiang Khong - Huay Xai",
                    Origin = LaosDestinations.HuayXai,
                    Final = ThailandDestinations.ChiangKhong,
                    Description = "",
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },

                }

                         ,

                new Frontier
                {
                    Name = "Padang Pesar - Padang Pesar (Pekan Siam)",
                    Origin = MalaysiaDestinations.PadangPesar,
                    Final = ThailandDestinations.PadangPesar,
                   FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },

                }

                         ,

                new Frontier
                {
                    Name = "Sungai Kolok - Rantan Panjang",
                    Origin = MalaysiaDestinations.RantanPanjang,
                    Final = ThailandDestinations.SungaiKolok,
                     FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                }

                         ,

                new Frontier
                {
                    Name = "Chong Mek - Vang Tao",
                    Origin = LaosDestinations.ChongMek,
                    Final = ThailandDestinations.VangTao,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                }

                ,


                new Frontier
                {
                    Name = "Aranyaprathet",
                    Origin = CambodiaDestinations.Poipet,
                    Final = ThailandDestinations.Aranyaprathet,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                }

               
            };
        }

        public static List<Frontier> CreateFrontiersFromInternationalAirports()
        {
            List<Frontier> frontiers = new List<Frontier>();


            var airports = ThailandAirports.GetAll();

            foreach (var airport in airports.Where(a=> a.AirportType == AirportTypes.International)) {

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

        public static List<Frontier> GetAll()

        {
            List<Frontier> terrestrial = GetAllTerrestrialFrontiers();

            List<Frontier> frontiersFromAirports = CreateFrontiersFromInternationalAirports();

            terrestrial.AddRange(frontiersFromAirports);

            return terrestrial;

        }
    }
}
    
