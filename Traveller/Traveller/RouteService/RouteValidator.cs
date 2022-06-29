using System;
using System.Collections.Generic;

namespace Traveller.RouteService
{
    public class RouteValidator
    {
        List<IRule> rules = new List<IRule>();
        public RouteValidator(List<IRule> rules)
        {

            this.rules = rules;

        }


        public bool Validate(List<char> route)
        {
            foreach (IRule rule in rules)
            {
                if (!rule.Validate(route)) return false;
            }

            return true;
        }

        public override string ToString()
        {

            string summary = "";

            foreach (IRule rule in this.rules)
            {
                summary = summary + rule.ToString() + Environment.NewLine;
            }

            return summary;
        }


        public List<IRule> Incumple(List<char> route)
        {
            List<IRule> rules_broken = new List<IRule>();
            foreach (IRule rule in rules)
            {
                if (!rule.Validate(route)) rules_broken.Add(rule);
            }

            return rules_broken;
        }



    }
}
