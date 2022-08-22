using Domain.Ranges.WithDictionary;
using System.Collections.Generic;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace Traveller.RuleService
{
    public class XXXMalasyaTailandiaLongStayRuleContainer : IRuleContainer
    {
        private List<IRule> rules = new List<IRule>();

        public List<char> Vector { get; set; } = new List<char>();

        public XXXMalasyaTailandiaLongStayRuleContainer()
        {

            //TODO USAR OR PARA ESTANCIAS T=3 (Visado Turista mas extension en inmigracion)

            //TODO Probar si que X = 3 se consigue mejor valoracion estacional 


            rules.Add(new TotalStayinYearMustBeLessThanXMonth('M', 6));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('T', 6));

            //rules.Add(new EachStayMustBeLessThanXMonth('T', 2));        
            //rules.Add(new EachStayMustBeLessThanXMonth('M', 3));


            //var T2M3 = new AndCondition(new List<IRule> { new EachStayMustBeLessThanXMonth('T', 2), new EachStayMustBeLessThanXMonth('M', 3), new TotalStayinYearMustBeLessThanXMonth('X', 2) });
            //var T3M3 = new AndCondition(new List<IRule> { new EachStayMustBeLessThanXMonth('T', 3), new EachStayMustBeLessThanXMonth('M', 3), new TotalStayinYearMustBeLessThanXMonth('X', 1) });


            var T2M3 = new AndCondition(new List<IRule> { new EachStayMustBeLessThanXMonth('T', 2), new EachStayMustBeLessThanXMonth('M', 3) }); //Visa Turista
            var T3M3 = new AndCondition(new List<IRule> { new EachStayMustBeLessThanXMonth('T', 3), new EachStayMustBeLessThanXMonth('M', 3) }); //Visa Turista + Extension

            rules.Add(new OrCondition(new List<IRule> {
                T2M3,
                T3M3,
            }));


            rules.Add(new AnualEntriesMustBeLessThanX('T', 2));
            rules.Add(new AnualEntriesMustBeLessThanX('M', 2));

            //rules.Add(new TotalStayinYearMustBeXMonth('X', 3));  //LVC VCL 

            ////Con esta condicion se puede realizar cv
            //rules.Add(new BlockConnection('M', 'X', false));



            rules.Add(new MustConsiderWeather(new List<RangeIntWithDictionary> {
               
                //Se aplican aqui los meses menos restrictivos
                new RangeIntWithDictionary { Id = 'M', Values = new List<int> {1, 1, 1,1,1,1,1,1,1, 1,- 1,- 1 } } ,
               new RangeIntWithDictionary { Id = 'T', Values = new List<int> { 1, 1, 1,1,1,-1,-1,-1,1,  1, 1, 1 } } ,
                //new RangeIntWithDictionary { Id = 'X', Values = new List<int> { 1, 1, 1,1,1,-1,-1,-1,-1, 1, 1, 1 } } ,

            }));

            //Ofrece 266 resultados

            //Añadimos condicion para que la estancia fuera de M y T (X) sea de tres meses consecutivos


            //rules.Add(new OneStayYearWithXConsecutiveMonths('X', 3));

            //Se reducen a 32 posibilidades
        }

        public void AddRule(IRule rule)
        {

            rules.Add(rule);

        }

        public List<char> GetDestinationByMonth(int month)
        {

            List<char> chs = new List<char>();
            foreach (IRule r in rules)
            {
                if (r.GetType() == typeof(MustConsiderWeather))
                {

                    MustConsiderWeather mustConsiderWeather = (MustConsiderWeather)r;
                    chs.AddRange(mustConsiderWeather.MonthReport(month));

                }
            }

            return chs;
        }

        public List<IRule> GetRules()
        {
            return this.rules;
        }

        public List<char> GetVector()
        {
            return new List<char> { };
        }
    }

}