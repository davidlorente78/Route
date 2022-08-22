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


        public List<string> GetBrokenRules(List<char> route)
        {
            List<string> rules_broken = new List<string>();
            foreach (IRule rule in rules)
            {
                if (!rule.Validate(route)) rules_broken.Add(rule.ToString());
            }

            return rules_broken;
        }



    }
}
