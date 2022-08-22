using System;
using System.Collections.Generic;

namespace Traveller.RouteService.Rules
{
    public class AndCondition : IRule
    {
        List<IRule> rules = new List<IRule>();

        public AndCondition(List<IRule> rules)
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
            string summary = "All of the following conditions must be met : ";

            foreach (IRule rule in this.rules)
            {
                summary = summary + rule.ToString();
            }

            summary = summary + Environment.NewLine;
            return summary;
        }
    }
}