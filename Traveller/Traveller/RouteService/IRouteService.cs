using System.Collections.Generic;

namespace Traveller.RouteService
{
    public interface IRouteService
    {
        public List<IRule> BrokenRules(List<char> route);

    }

}





