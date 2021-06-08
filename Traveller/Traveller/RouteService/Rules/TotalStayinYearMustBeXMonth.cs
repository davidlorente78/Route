using System;
using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.RouteService.Rules
{
    public class TotalStayinYearMustBeXMonth : IRule
    {
        Char countryCode;
        int months ;


        public TotalStayinYearMustBeXMonth(char countryCode,int months) {

            this.countryCode = countryCode; this.months = months;

        }

        public bool Validate(List<char> route)
        {
            var ocurrences = route.FindAll(x => x==countryCode);
            if (ocurrences.Count != months) return false;
            else return true;
        }

        public override string ToString()
        {
            string summmary = "";

            summmary = "La estancia anual " + CodeDictionary.GetCountryByCode(countryCode) + " debe ser de  " + months.ToString () + " mes/es. ";                

            return summmary;
        }
    }
}
