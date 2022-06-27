using System.Collections.Generic;

namespace Traveller.RouteService
{
    public interface IRule
    {
        bool Validate(List<char> route);

    }
}
