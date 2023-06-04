using Domain.Ranges.WithDictionary;
using System.Collections.Generic;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace Traveller.RuleService
{
    public class XXXMalasyaTailandiaBasedRuleWithBaliContainer : IRuleContainer
    {
        private List<IRule> rules = new List<IRule>();


        public List<char> Vector { get; set; } = new List<char> { 'T', 'M', 'X', 'I', 'L', 'V', 'C' };
        public XXXMalasyaTailandiaBasedRuleWithBaliContainer()
        {
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('M', 3));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('T', 6));

            var T2M3 = new AndCondition(new List<IRule> { new EachStayMustBeLessThanXMonth('T', 2), new EachStayMustBeLessThanXMonth('M', 3) }); //Visa Turista
            var T3M3 = new AndCondition(new List<IRule> { new EachStayMustBeLessThanXMonth('T', 3), new EachStayMustBeLessThanXMonth('M', 3) }); //Visa Turista + Extension

            rules.Add(new OrCondition(new List<IRule> {
                T2M3,
                T3M3,
            }));

            rules.Add(new AnualEntriesMustBeLessThanX('T', 2));
            rules.Add(new AnualEntriesMustBeLessThanX('M', 2));

            rules.Add(new TotalStayinYearMustBeXMonth('X', 3));  //LVC VCL 

            //Con esta condicion se puede realizar cv
            rules.Add(new BlockConnection('M', 'X', false));
            rules.Add(new BlockConnection('I', 'X', false));

            rules.Add(new OneStayYearWithXConsecutiveMonths('X', 3));
            rules.Add(new OneStayYearWithXConsecutiveMonths('I', 1));

            rules.Add(new TotalStayinYearMustBeXMonth('I', 1));

            //Se reducen a 32 posibilidades
        }

        public void AddRule(IRule rule)
        {
            rules.Add(rule);
        }


        public List<IRule> GetRules()
        {
            return this.rules;
        }

        public void ResetRules()
        {
            this.rules.Clear();
        }

    }

}