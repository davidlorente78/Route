using System.Collections.Generic;
using Traveller.RouteService;

namespace Traveller.RuleService
{
    public interface IRuleContainer
    {
        public List<char> Vector { get; set; }

        public List<IRule> GetRules();
        List<char> GetDestinationByMonth(int month);

        public void AddRule(IRule rule);
    }
}