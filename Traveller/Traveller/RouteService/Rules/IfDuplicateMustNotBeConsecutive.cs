using System;
using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.RouteService.Rules
{
    public class IfDuplicateMustNotBeConsecutive : IRule
    {
        Char country_origin;

        public IfDuplicateMustNotBeConsecutive(Char country_origin)
        {


            this.country_origin = country_origin;

        }

        public bool Validate(List<char> route)
        {
            string s = string.Join("", route);

            char ch_origin = country_origin;
            int idx_origin = s.IndexOf(ch_origin);

            int idx_destination = s.LastIndexOf(ch_origin);

            int distance = idx_destination - idx_origin;

            if (route.FindAll(x => x == ch_origin).Count == 2)
            {

                if ((distance == 1) || (distance == -1) || (distance == route.Count - 1) || (distance == -(route.Count - 1))) return false;
                else return true;
            }
            else
            {

                return true;
            }

        }

        public override string ToString()
        {
            string summmary = "";

            summmary = CodeDictionary.GetCountryByCode(country_origin) + " the two visit months must not be consecutive.";

            return summmary;
        }
    }
}
