﻿using System;
using System.Collections.Generic;
using Traveller.Domain;
using Traveller.RouteService.Helpers;

namespace Traveller.RouteService.Rules
{
    public class OneStayYearWithXConsecutiveMonths : IRule
    {
        Char countryCode;
        int months;


        public OneStayYearWithXConsecutiveMonths(char countryCode, int months)
        {

            this.countryCode = countryCode; this.months = months;

        }

        public bool Validate(List<char> route)
        {
            string s = string.Join("", route);

            var groupby = Helper.DetectRepeatedChars(route);

            var countryItems = groupby.FindAll(x => x.Item1 == countryCode);

            if ((countryItems.Count == 1) && (countryItems.FindAll(x => x.Item2 == months).Count == 1))
            {
                return true;

            }


            return false;
        }

        public override string ToString()
        {
            string summmary = "";

            summmary = "The stay in " + CodeDictionary.GetCountryByCode(countryCode) + " it must be unique during the year and have exactly " + months.ToString() + " month/s of duration. ";

            return summmary;
        }
    }
}
