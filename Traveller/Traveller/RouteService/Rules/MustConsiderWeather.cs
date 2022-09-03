using Domain.EntityFrameworkDictionary;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;

namespace Traveller.RouteService.Rules
{
    public class MustConsiderWeather : IRule
    {


        private EntityFrameworkDictionary<int, int> EntityEvaluator_ByMonth;

        private int StartMonth = 0;

        private char CountryCode;

        private List<char> route = new List<char>();
        public MustConsiderWeather(EntityFrameworkDictionary<int, int> EntityEvaluator_ByMonth, char CountryCode, int StartMonth)
        {
            //January will be 0
            this.StartMonth = StartMonth;
            this.CountryCode = CountryCode;
            this.EntityEvaluator_ByMonth = EntityEvaluator_ByMonth;
        }

        public bool Validate(List<char> route)
        {
            this.route = route;

            var routeVectorEndIndex = route.Count + StartMonth;

            for (int x = StartMonth; x < routeVectorEndIndex; x++)
            {
                var routeVectorIndex = x - StartMonth;
                var ElementAt = EntityEvaluator_ByMonth.Items.ElementAt(x - 1);
                if ((route[routeVectorIndex] == CountryCode) && (ElementAt.Value == -1))
                {
                    return false;
                };
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
                    report.Add(CodeDictionary.GetMonthByInt(x + 1) + " weather " + " in " + CodeDictionary.GetCountryByCode(CountryCode) + " is not convenient");
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
