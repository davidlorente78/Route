using System;
using System.Collections.Generic;
using System.Text;

namespace Traveller.RouteService.Evaluator
{
    public interface IEvaluator
    {
        double Evaluate(List<char> route);
        List<Tuple<char, string>>  Report(List<char> route);
    }
}
