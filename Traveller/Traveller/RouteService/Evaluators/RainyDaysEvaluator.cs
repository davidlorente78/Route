﻿using Domain.Ranges.WithDictionary;
using System;
using System.Collections.Generic;
using Traveller.RouteService.Evaluator;

namespace Traveller.RouteService.Evaluators
{
    class RainyDaysEvaluator : IEvaluator
    {

        List<RangeCharWithDictionary> ranges = new List<RangeCharWithDictionary>();

        //average number of days with some rainfall
        //average amount of rainfall

        public RainyDaysEvaluator(List<RangeCharWithDictionary> ranges)
        {

            this.ranges = ranges;
        }

        public double Evaluate(List<char> route)
        {
            throw new NotImplementedException();
        }

        public List<Tuple<char, string>> Report(List<char> route)
        {
            throw new NotImplementedException();
        }

        //https://www.weather2travel.com/monthly-rainy-days/?destination_name=Thailand&id=543#rain



    }
}
