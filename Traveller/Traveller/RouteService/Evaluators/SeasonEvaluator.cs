using System;
using System.Collections.Generic;
using Traveller.RouteService.DataContainer;

namespace Traveller.RouteService.Evaluator
{
    public class SeasonEvaluator: IEvaluator
    {
        List<CharRange> ranges = new List<CharRange>();
        public SeasonEvaluator(SeasonDataContainer dataContainer)
        {

            this.ranges = dataContainer.rangesList;
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

            switch (eval) {

                case 'A':
                    return 100;

                case 'M':
                    return 50;

                case 'B':
                    return 0;


                default:
                    return -1;

            }

        }


        public List<Tuple<char, string>> Report(List<char> route)
        {
            List<Tuple<char, string>> report = new List<Tuple<char, string>>();
            int index = 0;
            foreach (char coutryCode in route)
            {
                if (coutryCode != 'X')
                {
                    string description;
                    var season = this.ranges.Find(x => x.Id == coutryCode).Values[index];
                    this.ranges.Find(x => x.Id == coutryCode).Description.TryGetValue(season, out description);
                    index++;


                    report.Add(Tuple.Create(season, description));

                }

                else
                {

                    report.Add(Tuple.Create('X', "Out of consideration"));
                }
            }



            return report;
        }

    }

    }

