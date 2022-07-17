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
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }


                }

                         ,
                new Frontier {
                    Name = "Padang Pesar",
                    Origin = ThailandDestinations.PadangPesar,
                    Final = MalaysiaDestinations.PadangPesar,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }
                }

                         ,

                new Frontier {
                    Name = "Sungai Kolok - Rantan Panjang",
                    Origin = ThailandDestinations.SungaiKolok,
                    Final = MalaysiaDestinations.RantanPanjang,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }
                }

                         ,

                new Frontier {
                    Name = MalaysiaDestinations.JohorBahru.Name,
                    Origin = SingaporeDestinations.WoodlandsCheckpoint,
                    Final = MalaysiaDestinations.JohorBahru,
                    Visas = new List<Visa> { MalaysiaVisas.freeVisa, MalaysiaVisas.eVisa }

                }
            };
        }
    } }




