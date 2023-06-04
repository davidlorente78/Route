using Domain.Ranges.WithDictionary;
using System.Collections.Generic;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace Traveller.RuleService
{
    public class XXXMalasyaTailandiaZonesRuleContainer : IRuleContainer
    {
        private List<IRule> rules = new List<IRule>();
        public List<char> Vector { get; set; } = new List<char> { 'N', 'T', 'L', 'C', 'V', 'K', 'O', 'M', 'M', 'W', 'I' };

        /// <summary>
        /// Laos-Vietnam-Cambodia-Thailand-Malaysia-Bali-Malaysia-Indonesia-Malaysia-Penang-Kochi-Chiang Mai-
        ///Laos-Vietnam-Cambodia-Thailand-Malaysia-Indonesia-Malaysia-Bali-Malaysia-Penang-Kochi-Chiang Mai-
        /// </summary>
        public XXXMalasyaTailandiaZonesRuleContainer()
        {
            //Vietnam-Chiang Mai-Cambodia-Vietnam-Laos-Bali-Malaysia-Malaysia-Indonesia-Penang-Thailand-Kochi-

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


            //Conexion con Indico
            rules.Add(new OrCondition(new List<IRule> {
                new CountryBMustFollowCountryA('M', 'K', false),
                new CountryBMustFollowCountryA('T', 'K', false),
                new CountryBMustFollowCountryA('N', 'K', false),
                new CountryBMustFollowCountryA('W', 'K', false)
            }));


            rules.Add(new CountryBMustFollowCountryA('L', 'V', false));
            rules.Add(new CountryBMustFollowCountryA('V', 'C', false));


            //Duracion de las estancias           
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('C', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('L', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('O', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('W', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('N', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('V', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('I', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('M', 6));

            rules.Add(new EachStayMustBeLessThanXMonth('T', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('N', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('O', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('I', 1));
            rules.Add(new EachStayMustBeLessThanXMonth('M', 3));


            //Bloqueo acceso Indonesia
            rules.Add(new BlockConnection('I', 'V', false));
            rules.Add(new BlockConnection('I', 'L', false));
            rules.Add(new BlockConnection('I', 'C', false));
            rules.Add(new BlockConnection('I', 'K', false));


            rules.Add(new BlockConnection('O', 'V', false));
            rules.Add(new BlockConnection('O', 'L', false));
            rules.Add(new BlockConnection('O', 'C', false));
            rules.Add(new BlockConnection('O', 'K', false));

            rules.Add(new BlockConnection('L', 'M', false));
            rules.Add(new BlockConnection('L', 'W', false));
            rules.Add(new BlockConnection('C', 'W', false));
            rules.Add(new BlockConnection('C', 'M', false));



            rules.Add(new BlockConnection('T', 'N', false));
            rules.Add(new BlockConnection('I', 'O', false));

            rules.Add(new BlockConnection('C', 'K', false));
            rules.Add(new BlockConnection('L', 'K', false));
            rules.Add(new BlockConnection('V', 'K', false));


            //rules.Add(new MustConsiderWeather(new List<RangeIntWithDictionary> {
            //    new RangeIntWithDictionary { Id = 'V', Values = new List<int> { 1,1,1,1,-1,-1,-1,-1,-1,-1,-1,-1 } } ,
            //    new RangeIntWithDictionary  { Id = 'L',  Values = new List<int> { 1, 1, -1,-1,1,1,1,-1,-1, 1, 1, 1 } } ,
            //    new RangeIntWithDictionary  { Id = 'M', Values = new List<int> { -1, -1, 1,1,1,1,1,1,1, -1,- 1,- 1 } } ,
            //    new RangeIntWithDictionary  { Id = 'T', Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,-1, -1, 1, 1 } } ,
            //    new RangeIntWithDictionary  { Id = 'C',  Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,1, 1, 1, 1 } } ,
            //    new RangeIntWithDictionary  { Id = 'N',  Values = new List<int> { 1, 1, 1,-1,-1,-1,-1,-1, -1, -1, 1, 1 } } ,
            //    new RangeIntWithDictionary  { Id = 'I',  Values = new List<int> { -1, -1, -1,-1,1,1,1,1,1, -1, -1, -1 } } ,
            //    new RangeIntWithDictionary  { Id = 'O',  Values = new List<int> { -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, -1 } } ,
            //    new RangeIntWithDictionary  { Id = 'W',  Values = new List<int> { -1, -1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 } } ,
            //    new RangeIntWithDictionary  { Id = 'K',  Values = new List<int> { 1, 1, 1,-1, -1,- 1, -1, -1,- 1, -1, 1, 1 } } ,

            //}));



        }

        public void AddRule(IRule rule)
        {

            rules.Add(rule);

        }
        public List<char> GetDestinationByMonth(int month)
        {

            List<char> chs = new List<char>();
            //foreach (IRule r in rules)
            //{
            //    if (r.GetType() == typeof(MustConsiderWeather))
            //    {

            //        MustConsiderWeather mustConsiderWeather = (MustConsiderWeather)r;
            //        chs.AddRange(mustConsiderWeather.MonthReport(month));

            //    }
            //}

            return chs;
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