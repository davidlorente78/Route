using Traveller.Domain;
using Traveller.StaticData;

namespace StaticData.Malasia
{
    public class MalasiaFrontiers
    {

        public static ICollection<Frontier> GetAll()
        {
            return  new List<Frontier> {


                new Frontier {
                    Name = MalasiaDestinations.KUL.Name,
                    Origin = MalasiaDestinations.KUL,
                    Final = MalasiaDestinations.KUL,
                    Visas = new List<Visa> { MalasiaVisas.freeVisa, MalasiaVisas.eVisa }


                }

                         ,
                new Frontier {
                    Name = "Padang Pesar",
                    Origin = ThailandDestinations.PadangPesar,
                    Final = MalasiaDestinations.PadangPesar,
                    Visas = new List<Visa> { MalasiaVisas.freeVisa, MalasiaVisas.eVisa }
                }

                         ,

                new Frontier {
                    Name = "Sungai Kolok - Rantan Panjang",
                    Origin = ThailandDestinations.SungaiKolok,
                    Final = MalasiaDestinations.RantanPanjang,
                    Visas = new List<Visa> { MalasiaVisas.freeVisa, MalasiaVisas.eVisa }
                }

                         ,

                new Frontier {
                    Name = MalasiaDestinations.JohorBahru.Name,
                    Origin = SingaporeDestinations.WoodlandsCheckpoint,
                    Final = MalasiaDestinations.JohorBahru,
                    Visas = new List<Visa> { MalasiaVisas.freeVisa, MalasiaVisas.eVisa }

                }
            };
        }
    } }




