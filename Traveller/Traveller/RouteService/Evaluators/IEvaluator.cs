using System;
using System.Collections.Generic;

namespace Traveller.RouteService.Evaluator
{
    public interface IEvaluator
    {
        double Evaluate(List<char> route);
        List<Tuple<char, string>> Report(List<char> route);
    }
}
