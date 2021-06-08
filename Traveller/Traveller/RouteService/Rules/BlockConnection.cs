using System;
using System.Collections.Generic;
using Traveller.Domain;
using Traveller.RouteService.Helpers;

namespace Traveller.RouteService.Rules
{
    public class BlockConnection : IRule
    {
        Char country_origin;
        Char country_destination;
        bool oneDirection;

        public BlockConnection(Char country_origin, Char country_destination, bool oneDirection)
        {

            this.country_destination = country_destination;
            this.country_origin = country_origin;
            this.oneDirection = oneDirection;
        }

        public bool Validate(List<char> route)
        {
            string s = string.Join("", route);
            int min = Helper.distance(s,country_origin,country_destination);


            if (oneDirection)
            {   //Tiene en cuenta el sentido indicado
                if (min == 0) return false;
                else return true;
            }
            else
            {
                //Ofrece soluciones en ambos sentidos
                if ((min == 0) || (min == route.Count - 2)) return false;
                else return true;
            }

        }



    public override string ToString()
        {
            string summmary = "";

            summmary = "No deben considerarse las conexiones directas entre " + CodeDictionary.GetCountryByCode(country_origin) + " y  " + CodeDictionary.GetCountryByCode(country_destination);

            if (oneDirection) { summmary = summmary + " en el orden indicado."  ; }

            else { summmary = summmary + " en ambos sentidos."  ; }

            return summmary;


        }
    }
}
