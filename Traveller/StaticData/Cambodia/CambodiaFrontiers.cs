using Traveller.Domain;

namespace Traveller.StaticData
{
    public static class CambodiaFrontiers
    {
        public static List<Frontier> Frontiers = new List<Frontier> {

               
                    new Frontier
                    {
                        Name = CambodiaDestinations.REP.Name, 
                        Origin = CambodiaDestinations.REP,
                        Final = CambodiaDestinations.REP,
                        Type = "A",
                      }

                   

                    //Lao Bao Pass: Es el borde fronterizo más popular, si bien estaba demasiado al Sur como para resultarnos de interés. Queda muy cerca de Hué.
    };

    
    }
}
