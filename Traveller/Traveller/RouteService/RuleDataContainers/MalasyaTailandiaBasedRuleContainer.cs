using System.Collections.Generic;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace Traveller.RuleService
{
    public class MalasyaTailandiaBasedRuleContainer : IRuleContainer
    {
        private List<IRule> rules = new List<IRule>();

        public List<char> vector = new List<char> { 'N', 'T', 'L', 'C', 'V', 'O', 'M', 'M', 'W', 'I', 'V' };

        public MalasyaTailandiaBasedRuleContainer()
        {

            //Conexiones con Indonesia
            rules.Add(new OrCondition(new List<IRule> {

                new CountryBMustFollowCountryA('I', 'M', true),
                new CountryBMustFollowCountryA('I', 'T', true),//Por conexiones
                new CountryBMustFollowCountryA('I', 'W', true),
                new CountryBMustFollowCountryA('I', 'N', true),//Por conexiones
            }));

            rules.Add(new OrCondition(new List<IRule> {

                new CountryBMustFollowCountryA( 'M', 'I',true),
                new CountryBMustFollowCountryA( 'T', 'I',true),
                new CountryBMustFollowCountryA( 'W', 'I',true),
                new CountryBMustFollowCountryA( 'N', 'I',true),
            }));


            rules.Add(new CountryBMustFollowCountryA('L', 'V', false));
            rules.Add(new CountryBMustFollowCountryA('V', 'C', false));


            //Duracion de las estancias           
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('C', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('L', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('O', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('W', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('N', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('I', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('M', 6));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('V', 2));

            rules.Add(new EachStayMustBeLessThanXMonth('T', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('N', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('O', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('I', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('M', 3));
            rules.Add(new EachStayMustBeLessThanXMonth('V', 2)); //VISA EXT


            //Bloqueo acceso Indonesia
            rules.Add(new BlockConnection('I', 'V', false));
            rules.Add(new BlockConnection('I', 'L', false));
            rules.Add(new BlockConnection('I', 'C', false));



            rules.Add(new BlockConnection('O', 'V', false));
            rules.Add(new BlockConnection('O', 'L', false));
            rules.Add(new BlockConnection('O', 'C', false));


            rules.Add(new BlockConnection('L', 'M', false));
            rules.Add(new BlockConnection('L', 'W', false));
            rules.Add(new BlockConnection('C', 'W', false));
            rules.Add(new BlockConnection('C', 'M', false));



            rules.Add(new BlockConnection('T', 'N', false));
            rules.Add(new BlockConnection('I', 'O', false));




            rules.Add(new MustConsiderWeather(new List<IntegerRange> {
                new IntegerRange { Id = 'V', Values = new List<int> { 1,1,1,1,1,-1,-1,-1,-1,-1,-1,1 } } ,
                new IntegerRange { Id = 'L', Values = new List<int> { 1, 1, -1,-1,1,1,1,-1,-1, 1, 1, 1 } } ,
                new IntegerRange { Id = 'M', Values = new List<int> { -1, -1, 1,1,1,1,1,1,1, -1,- 1,- 1 } } ,
                new IntegerRange { Id = 'T', Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,-1, -1, 1, 1 } } ,
                new IntegerRange { Id = 'C', Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,1, 1, 1, 1 } } ,
                new IntegerRange { Id = 'N', Values = new List<int> { 1, 1, 1,-1,-1,-1,-1,-1, -1, -1, 1, 1 } } ,
                new IntegerRange { Id = 'I', Values = new List<int> { -1, -1, -1,-1,1,1,1,-1,1, -1, -1, -1 } } ,
                new IntegerRange { Id = 'O', Values = new List<int> { -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, -1, -1 } } ,
                new IntegerRange { Id = 'W', Values = new List<int> { -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } } ,

            }));



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
            return this.vector;
        }
    }

}