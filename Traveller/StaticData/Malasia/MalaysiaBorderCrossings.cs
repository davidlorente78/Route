using Data.EntityTypes;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Malaysia
{
    public class MalaysiaBorderCrossings
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


            var airports = MalaysiaAirports.GetAll();

            foreach (var airport in airports.Where(a => a.AirportType == AirportTypes.International))
            {

                BorderCrossing frontierFromAirport = new BorderCrossing()
                {
                    Name = airport.Name,
                    Description = airport.Name,
                    Origin = airport.Destinations.FirstOrDefault(),
                    Final = airport.Destinations.FirstOrDefault(),
                    BorderCrossingType = FrontierTypes.Airport,
                    Visas = new List<Visa> { ThailandVisas.VisaExemption_Thailand },
                };

                frontiers.Add(frontierFromAirport);


            }

            return frontiers;

        }
        public static List<BorderCrossing> GetAllTerrestrialFrontiers()
        {
            return  new List<BorderCrossing> {


               new BorderCrossing {
                    Name = "Padang Pesar",
                    Origin = ThailandDestinations.PadangPesar,
                    Final = MalaysiaDestinations.PadangPesar,
                    BorderCrossingType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia }
                }

                         ,

                new BorderCrossing {
                    Name = "Sungai Kolok - Rantan Panjang",
                    Origin = ThailandDestinations.SungaiKolok,
                    Final = MalaysiaDestinations.RantanPanjang,
                    BorderCrossingType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia }
                }

                         ,

                new BorderCrossing {
                    Name = MalaysiaDestinations.JohorBahru.Name,
                    Origin = SingaporeDestinations.WoodlandsCheckpoint,
                    //https://onemotoring.lta.gov.sg/content/onemotoring/home/driving/traffic_information/traffic-cameras/woodlands.html#trafficCameras
                    Final = MalaysiaDestinations.JohorBahru,
                    BorderCrossingType = FrontierTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia }

                }
            };
        }
    } }




