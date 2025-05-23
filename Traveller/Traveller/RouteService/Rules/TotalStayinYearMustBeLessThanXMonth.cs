﻿using System;
using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.RouteService.Rules
{
    public class TotalStayinYearMustBeLessThanXMonth : IRule
    {
        Char countryCode;
        int maxMonths;


        public TotalStayinYearMustBeLessThanXMonth(char countryCode, int maxMonths)
        {

            this.countryCode = countryCode; this.maxMonths = maxMonths;

        }

        public bool Validate(List<char> route)
        {
            var ocurrences = route.FindAll(x => x == countryCode);
            if (ocurrences.Count > maxMonths) return false;
            else return true;
        }

        public override string ToString()
        {
            string summmary = "";

            summmary = "The annual stay " + CodeDictionary.GetCountryByCode(countryCode) + " cannot exceed " + maxMonths.ToString() + " month(s). ";

            return summmary;
        }
    }
}
