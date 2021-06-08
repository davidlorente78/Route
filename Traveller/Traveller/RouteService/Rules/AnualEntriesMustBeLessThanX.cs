using System;
using System.Collections.Generic;
using Traveller.Domain;
using Traveller.RouteService.Helpers;

namespace Traveller.RouteService.Rules
{
    public class AnualEntriesMustBeLessThanX : IRule
    {
        Char country_origin;
        int numberEntries;
        public AnualEntriesMustBeLessThanX(Char country_origin, int numberEntries) {

            
            this.country_origin = country_origin;
            this.numberEntries = numberEntries;
        }

        public bool Validate(List<char> route)
        {


            var entries = Helper.CountNumberofEntries(route);

            var entriestoCountry = entries.FindAll(x => x.Item1 == country_origin);

            foreach (Tuple<char, int> t in entriestoCountry)
            {

                if (t.Item2 > numberEntries) return false;
            }

            return true;
        }
        
        public override string ToString()
        {
            string summmary = "";

            summmary = "El numero de entradas anuales a " + CodeDictionary.GetCountryByCode(country_origin) + " queda limitado  a  " + numberEntries.ToString();

            
            return summmary;
        }
    }
}
