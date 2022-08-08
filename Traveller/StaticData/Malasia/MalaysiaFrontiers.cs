using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Malaysia
{
    public class MalaysiaFrontiers
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


            var airports = MalaysiaAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {

                Frontier frontierFromAirport = new Frontier()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    Origin = airport.ServingDestinations.FirstOrDefault(),
                    Final = airport.ServingDestinations.FirstOrDefault(),
                    FrontierType = FrontierTypes.Airport,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }
        public static List<Frontier> GetAllTerrestrialFrontiers()
        {
            return  new List<Frontier> {


               new Frontier {
                    Name = "Padang Pesar",
                    Origin = ThailandDestinations.PadangPesar,
                    Final = MalaysiaDestinations.PadangPesar,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }
                }

                         ,

                new Frontier {
                    Name = "Sungai Kolok - Rantan Panjang",
                    Origin = ThailandDestinations.SungaiKolok,
                    Final = MalaysiaDestinations.RantanPanjang,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }
                }

                         ,

                new Frontier {
                    Name = MalaysiaDestinations.JohorBahru.Name,
                    Origin = SingaporeDestinations.WoodlandsCheckpoint,
                    //https://onemotoring.lta.gov.sg/content/onemotoring/home/driving/traffic_information/traffic-cameras/woodlands.html#trafficCameras
                    Final = MalaysiaDestinations.JohorBahru,
                    FrontierType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }

                }
            };
        }
    } }




