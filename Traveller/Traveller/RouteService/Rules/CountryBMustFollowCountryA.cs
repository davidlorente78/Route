using System;
using System.Collections.Generic;
using Traveller.Domain;
using Traveller.RouteService.Helpers;

namespace Traveller.RouteService.Rules
{
    public class CountryBMustFollowCountryA : IRule
    {
        Char country_origin;
        Char country_destination;
        bool oneDirection;
        public CountryBMustFollowCountryA(Char country_origin, Char country_destination, bool oneDirection)
        {

            this.country_destination = country_destination;
            this.country_origin = country_origin;
            this.oneDirection = oneDirection;
        }

        public bool Validate(List<char> route)
        {
            string s = string.Join("", route);

            //s = "VNTKKOMMILWC";
            //country_origin = 'V';
            //country_destination = 'C';


            //TODO Rewrite with decompose
            int min = Helper.distance(s, country_origin, country_destination);



            //Vietnam-Chiang Mai-Thailand-Vietnam-Kochi-Bali-Malaysia-Malaysia-Indonesia-Laos-Penang-Cambodia-
            if (oneDirection)
            {   //Tiene en cuenta el sentido indicado
                if (min == 0) return true;
                else return false;
            }
            else
            {
                //Ofrece soluciones en ambos sentidos
                if ((min == 0) || (min == route.Count - 2)) return true;
                else return false;
            }

        }

        public override string ToString()
        {
            string summmary = "";

            summmary = CodeDictionary.GetCountryByCode(country_origin) + " and " + CodeDictionary.GetCountryByCode(country_destination) + " must be visited consecutively ";

            if (oneDirection) { summmary = summmary + " in the indicated order."; }

            else { summmary = summmary + " in any order."; }

            return summmary;
        }
    }
}
