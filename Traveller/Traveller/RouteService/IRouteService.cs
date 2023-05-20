using System.Collections.Generic;
using Traveller.RuleService;

namespace Traveller.RouteService
{
    public interface IRouteService
    {
        public IRuleContainer ruleContainer { get; set; }
        public List<string> BrokenRules(List<char> route);
        public List<List<char>> proposedRoutes(int months);

    }
}