using System;
using System.Collections.Generic;
using Traveller.RouteService.Evaluator;

namespace Traveller.RouteService
{
    public class RouteEvaluator
    {
        List<IEvaluator> evaluators = new List<IEvaluator>();
        public RouteEvaluator(List<IEvaluator> evaluators)
        {
            this.evaluators = evaluators;
        }

        public Tuple<List<char>, List<List<Tuple<char, string>>>, List<double>> EvaluateAndReport(List<char> route)
        {
            List<List<Tuple<char, string>>> reportsResults = this.Report(route);
            List<double> evaluationResults = this.Evaluate(route);

            return Tuple.Create(route, reportsResults, evaluationResults);
        }

        private List<double> Evaluate(List<char> route)
        {
            List<double> evaluations = new List<double>();
            foreach (IEvaluator evaluator in evaluators)
            {
                var evaluation = evaluator.Evaluate(route);
                evaluations.Add(evaluation);
            }

            return evaluations;
        }


        private List<List<Tuple<char, string>>> Report(List<char> route)
        {
            List<List<Tuple<char, string>>> reports = new List<List<Tuple<char, string>>>();

            foreach (IEvaluator evaluator in evaluators)
            {
                reports.Add(evaluator.Report(route));
            }

            return reports;
        }
    }
}
