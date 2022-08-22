using System;
using System.Collections.Generic;
using Traveller.Domain;
using Traveller.RouteService.Helpers;

namespace Traveller.RouteService.Rules
{
    public class EachStayMustBeLessThanXMonth : IRule
    {
        Char countryCode;
        int maxMonths;


        public EachStayMustBeLessThanXMonth(char countryCode, int maxMonths)
        {

            this.countryCode = countryCode; this.maxMonths = maxMonths;

        }

        public bool Validate(List<char> route)
        {
            string s = string.Join("", route);


            var groupby = Helper.DetectRepeatedChars(route);

            foreach (var t in groupby.FindAll(x => x.Item1 == countryCode))
            {

                if (t.Item2 > maxMonths) return false;


            }


            return true;
        }

        public override string ToString()
        {
            string summmary = "";
           

            summmary = "The same stay in " + CodeDictionary.GetCountryByCode(countryCode) + " cannot be extended for more than " + maxMonths.ToString() + " month(s). ";

            return summmary;
        }
    }
}
