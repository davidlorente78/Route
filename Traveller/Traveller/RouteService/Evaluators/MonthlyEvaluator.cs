using System;
using System.Collections.Generic;

namespace Traveller.RouteService.Evaluator
{
    public class MonthlyEvaluator : IEvaluator
    {
        List<IntegerRange> ranges = new List<IntegerRange>();
        public MonthlyEvaluator(List<IntegerRange> ranges)
        {

            this.ranges = ranges;
        }

        public double Evaluate(List<char> route)
        {
            int evaluation = 0;
            int index = 0;
            foreach (char coutryCode in route)
            {

                evaluation = evaluation + GetEvaluation(coutryCode, index);
                index++;

            }

            double eval = evaluation / route.Count;

            return eval;
        }

        private int GetEvaluation(char coutryCode, int index)
        {
            if (coutryCode == 'X') return 100;

            var eval = this.ranges.Find(x => x.Id == coutryCode).Values[index];

            return eval * 100;

        }


        public List<Tuple<char, string>> Report(List<char> route)
        {


            return new List<Tuple<char, string>> { Tuple.Create('X', "Esta ruta tiene " + Evaluate(route).ToString() + " puntos sobre 100.") };


        }

    }

}

