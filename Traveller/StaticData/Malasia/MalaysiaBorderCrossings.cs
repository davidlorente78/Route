using Data.EntityTypes;
using Data.Utils;
using Traveller.Domain;
using Traveller.StaticData;

namespace Data.Malaysia
{
    public class MalaysiaBorderCrossings
    {
        public static List<BorderCrossing> GetAll()
        {
            List<BorderCrossing> terrestrial = GetAllTerrestrialFrontiers();

            List<BorderCrossing> frontiersFromAirports = BorderCrossingUtils.CreateFrontiersFromInternationalAirports(MalaysiaAirports.GetAll(), new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia });

            terrestrial.AddRange(frontiersFromAirports);

            return terrestrial;
        }

        public static List<BorderCrossing> GetAllTerrestrialFrontiers()
        {
            return new List<BorderCrossing> {

               new BorderCrossing {
                    Name = "Padang Pesar",
                    DestinationOrigin = ThailandDestinations.PadangPesar,
                    DestinationFinal = MalaysiaDestinations.PadangPesar,
                    BorderCrossingType = BorderCrossingTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia }
                },
                new BorderCrossing {
                    Name = "Sungai Kolok - Rantan Panjang",
                    DestinationOrigin = ThailandDestinations.SungaiKolok,
                    DestinationFinal = MalaysiaDestinations.RantanPanjang,
                    BorderCrossingType = BorderCrossingTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia }
                },
                new BorderCrossing {
                    Name = MalaysiaDestinations.JohorBahru.Name,
                    DestinationOrigin = SingaporeDestinations.WoodlandsCheckpoint,
                    //https://onemotoring.lta.gov.sg/content/onemotoring/home/driving/traffic_information/traffic-cameras/woodlands.html#trafficCameras
                    DestinationFinal = MalaysiaDestinations.JohorBahru,
                    BorderCrossingType = BorderCrossingTypes.Terrestrial,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa_Malaysia, MalaysiaVisas.eVisa_Malaysia}
                }
            };
        }
    }
}




