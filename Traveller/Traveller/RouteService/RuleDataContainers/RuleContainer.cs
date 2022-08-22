using Domain.Ranges.WithDictionary;
using System.Collections.Generic;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace Traveller.RuleService
{
    public class RuleContainer : IRuleContainer
    {
        private List<IRule> rules = new List<IRule>();
        public List<char> Vector { get; set; } = new List<char>();

       
        public RuleContainer()
        {
         
          
        }

        public void AddRule(IRule rule)
        {

            rules.Add(rule);

        }
        public List<char> GetDestinationByMonth(int month)
        {

            List<char> chs = new List<char>();
            foreach (IRule r in rules)
            {
                if (r.GetType() == typeof(MustConsiderWeather))
                {

                    MustConsiderWeather mustConsiderWeather = (MustConsiderWeather)r;
                    chs.AddRange(mustConsiderWeather.MonthReport(month));

                }
            }

            return chs;
        }

        public List<IRule> GetRules()
        {
            return this.rules;
        }

        public List<char> GetVector()
        {
            return this.Vector;
        }
    }

}