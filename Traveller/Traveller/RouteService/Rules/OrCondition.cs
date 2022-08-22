using System;
using System.Collections.Generic;

namespace Traveller.RouteService.Rules
{
    public class OrCondition : IRule
    {
        List<IRule> rules = new List<IRule>();

        public OrCondition(List<IRule> rules)
        {
            this.rules = rules;
        }

        public bool Validate(List<char> route)
        {
            foreach (IRule rule in rules)
            {

                if (rule.Validate(route)) return true;

            }

            return false;
        }

        public override string ToString()
        {
            string summary = "One of the following conditions must be met :" + Environment.NewLine;

            foreach (IRule rule in this.rules)
            {
                summary = summary + rule.ToString() + Environment.NewLine; ;
            }

            return summary;
        }
    }
}