using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.RouteService
{
    public interface IRule
    {
        bool Validate(List<char> route);

    }
}
