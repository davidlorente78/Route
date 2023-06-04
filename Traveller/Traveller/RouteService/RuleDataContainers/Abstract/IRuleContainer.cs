using System.Collections.Generic;
using Traveller.RouteService;

namespace Traveller.RuleService
{
    public interface IRuleContainer
    {
        public List<char> Vector { get; set; }

        public List<IRule> GetRules();
    
        public void AddRule(IRule rule);

        public void ResetRules();
    }
}