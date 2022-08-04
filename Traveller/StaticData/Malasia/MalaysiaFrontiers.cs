using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Malaysia
{
    public class MalaysiaFrontiers
    {

        public static ICollection<Frontier> GetAll()
        {
            return  new List<Frontier> {


                new Frontier {
                    Name = MalaysiaDestinations.KUL.Name,
                    Origin = MalaysiaDestinations.KUL,
                    Final = MalaysiaDestinations.KUL,
                    FrontierType = FrontierTypes.Airport,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }
                    

                }

                         ,
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




