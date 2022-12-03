using Domain.EntityFrameworkDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;

namespace Traveller.RouteService.Rules
{
    public class MustConsiderWeather : IRule
    {
        private bool strict = true;

        private EntityFrameworkDictionary<int, int> EntityEvaluator_ByMonth;

        private int StartMonth = 0;

        private char CountryCode;

        private List<char> route = new List<char>();
        public MustConsiderWeather(EntityFrameworkDictionary<int, int> EntityEvaluator_ByMonth, char CountryCode, int StartMonth, bool strict)
        {
            //January will be 0
            this.StartMonth = StartMonth;
            this.CountryCode = CountryCode;
            this.EntityEvaluator_ByMonth = EntityEvaluator_ByMonth;
            this.strict = strict;
        }

        public bool Validate(List<char> route)
        {
            this.route = route;

            var routeVectorEndIndex = route.Count + StartMonth;

            //PAM
            var changeYear = false;
            if (routeVectorEndIndex > 11)
            {
                changeYear = true;
            }

            if (!changeYear)
            {
                for (int x = StartMonth; x < routeVectorEndIndex; x++)
                {
                    var routeVectorIndex = x - StartMonth;
                    var ElementAt = EntityEvaluator_ByMonth.Items.ElementAt(x - 1);

                    if ((route[routeVectorIndex] == CountryCode) && (ElementAt.Value == -1))
                    {
                        return false;
                    };

                    if (strict && (route[routeVectorIndex] == CountryCode) && (ElementAt.Value == 0))
                    {
                        return false;
                    };
                }
            }
            else
            {

                for (int x = StartMonth; x < 12; x++)
                {
                    var routeVectorIndex = Math.Abs(x - StartMonth);
                    var ElementAt = EntityEvaluator_ByMonth.Items.ElementAt(x - 1);

                    if ((route[routeVectorIndex] == CountryCode) && (ElementAt.Value == -1))
                    {
                        return false;
                    };

                    if (strict && (route[routeVectorIndex] == CountryCode) && (ElementAt.Value == 0))
                    {
                        return false;
                    };
                }

                for (int x = 0; x < StartMonth - route.Count - 12; x++)
                {
                    var routeVectorIndex = x - StartMonth;
                    var ElementAt = EntityEvaluator_ByMonth.Items.ElementAt(x - 1);

                    if ((route[routeVectorIndex] == CountryCode) && (ElementAt.Value == -1))
                    {
                        return false;
                    };

                    if (strict && (route[routeVectorIndex] == CountryCode) && (ElementAt.Value == 0))
                    {
                        return false;
                    };
                }


            }

            return true;
        }


        public List<string> Report()
        {
            List<string> report = new List<string>();

            for (int x = StartMonth; x < route.Count + StartMonth; x++)
            {
                if ((route[x - StartMonth] == CountryCode) && (EntityEvaluator_ByMonth.Items.ElementAt(x - StartMonth).Value == -1))
                {
                    report.Add(CodeDictionary.GetMonthByInt(x + 1) + " weather " + " in " + CodeDictionary.GetCountryByCode(CountryCode) + " is not convenient at all.");
                }

                if ((route[x - StartMonth] == CountryCode) && (EntityEvaluator_ByMonth.Items.ElementAt(x - StartMonth).Value == 0))
                {
                    report.Add(CodeDictionary.GetMonthByInt(x + 1) + " weather " + " in " + CodeDictionary.GetCountryByCode(CountryCode) + " can be better.");
                }
            }

            return report;
        }

        public override string ToString()
        {
            string summmary = "Considering weather of " + CodeDictionary.GetCountryByCode(CountryCode);

            foreach (string s in Report())
            {
                summmary = summmary + s + "\n";
            }

            return summmary;
        }
    }
}
