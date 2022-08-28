using Domain.EntityFrameworkDictionary;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;

namespace Traveller.RouteService.Rules
{
    public class MustConsiderWeather : IRule
    {
       

        private EntityFrameworkDictionary<int, int> EntityEvaluator_ByMonth;

        private int StartMonth = 1;

        private char CountryCode;

        private List<char> route = new List<char>();
        public MustConsiderWeather(EntityFrameworkDictionary<int, int> EntityEvaluator_ByMonth, char CountryCode, int StartMonth)
        {
            this.StartMonth = StartMonth;
            this.CountryCode = CountryCode;
            this.EntityEvaluator_ByMonth = EntityEvaluator_ByMonth;
        }

        public bool Validate(List<char> route)
        {
            this.route = route;

            for (int x = 0; x < route.Count; x++)
            {
                if ((route[x] == CountryCode) && (EntityEvaluator_ByMonth.Items.ElementAt(x).Value == -1)) return false;
            }                  

            return true;
        }


        public List<string> Report()
        {
            List<string> report = new List<string>();

            for (int x = 0; x < route.Count; x++)
            {
                if ((route[x] == CountryCode) && (EntityEvaluator_ByMonth.Items.ElementAt(x).Value == -1))
                {
                    report.Add(CodeDictionary.GetMonthByInt(x + 1)  + " weather " + " in " + CodeDictionary.GetCountryByCode(CountryCode) + " is not convenient");
                } 

            }

            return report;
        }      

        public override string ToString()
        {
            string summmary = "";

            //summmary = summmary + "Introduction  : ";
            
            foreach (string s in Report())
            {
                summmary = summmary + s + "\n";
            }

            return summmary;
        }
    }
}
