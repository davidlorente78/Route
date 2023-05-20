using System.Collections.Generic;
using Traveller.RuleService;

namespace Traveller.RouteService
{
    public class RouteService : IRouteService
    {
        public IRuleContainer ruleContainer { get; set; }

        public RouteService(IRuleContainer ruleContainer)
        {
            this.ruleContainer = ruleContainer;

        }

        public List<List<char>> proposedRoutes(int months)
        {

            RouteCombinationsGenerator routeCombinationsGenerator = new RouteCombinationsGenerator(ruleContainer);
            return routeCombinationsGenerator.Generate(months);
        }

        public List<string> BrokenRules(List<char> route)
        {

            List<IRule> rules = ruleContainer.GetRules();
            RouteValidator routeValidator = new RouteValidator(rules);

            var brokenRules = routeValidator.GetBrokenRules(route);

            return brokenRules;
        }
    }
}

