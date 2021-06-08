using System.Collections.Generic;
using Traveller.RouteService;

namespace Traveller.RuleService
{
    public interface IRuleContainer
    {
        List<IRule> GetRules();

        List<char> GetVector();
        List<char> GetDestinationByMonth(int month);
    }
}