using System.Collections.Generic;
using Traveller.RouteService;

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

        public List<IRule> GetRules()
        {
            return this.rules;
        }
        
        public void ResetRules()
        {
            rules.Clear();
        }
    }
}