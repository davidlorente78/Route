using Domain.Ranges.WithDictionary;
using System.Collections.Generic;
using Traveller.RouteService;
using Traveller.RouteService.Rules;

namespace Traveller.RuleService
{
    public class XXXAllDestinationsRuleContainer : IRuleContainer
    {
        public List<IRule> rules = new List<IRule>();

        public List<char> Vector { get; set; } =  new List<char> { 'B', 'T', 'L', 'C', 'V', 'H', 'K', 'S', 'M', 'G', 'I' };

        /// <summary>
        /// Vietnam-Myanmar-Cambodia-Vietnam-Laos-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Hainan-
        //Thailand-Myanmar-Cambodia-Vietnam-Laos-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Hainan-
        //Vietnam-Laos-Vietnam-Cambodia-Myanmar-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Hainan-
        //Thailand-Laos-Vietnam-Cambodia-Myanmar-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Hainan-
        //Vietnam-Laos-Vietnam-Cambodia-Myanmar-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Hainan-
        //Thailand-Laos-Vietnam-Cambodia-Myanmar-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Hainan-
        //Vietnam-Laos-Vietnam-Cambodia-Myanmar-Indonesia-Malaysia-Singapore-Sri Lanka-Kochi-Thailand-Hainan-
        //Thailand-Laos-Vietnam-Cambodia-Myanmar-Indonesia-Malaysia-Singapore-Sri Lanka-Kochi-Thailand-Hainan-
        //Vietnam-Laos-Vietnam-Cambodia-Myanmar-Indonesia-Singapore-Malaysia-Sri Lanka-Kochi-Thailand-Hainan-
        //Thailand-Laos-Vietnam-Cambodia-Myanmar-Indonesia-Singapore-Malaysia-Sri Lanka-Kochi-Thailand-Hainan-
        //Sri Lanka-Thailand-Cambodia-Vietnam-Laos-Myanmar-Indonesia-Malaysia-Singapore-Hainan-Thailand-Kochi-
        //Sri Lanka-Thailand-Cambodia-Vietnam-Laos-Myanmar-Indonesia-Singapore-Malaysia-Hainan-Thailand-Kochi-
        //Laos-Vietnam-Cambodia-Vietnam-Hainan-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Myanmar-
        //Laos-Vietnam-Cambodia-Thailand-Hainan-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Myanmar-
        //Laos-Vietnam-Cambodia-Vietnam-Hainan-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Myanmar-
        //Laos-Vietnam-Cambodia-Thailand-Hainan-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Myanmar-
        //Vietnam-Laos-Myanmar-Malaysia-Hainan-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Cambodia-
        //Vietnam-Laos-Myanmar-Thailand-Hainan-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Cambodia-
        //Vietnam-Laos-Myanmar-Malaysia-Hainan-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Cambodia-
        //Vietnam-Laos-Myanmar-Thailand-Hainan-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Cambodia-
        //Vietnam-Cambodia-Myanmar-Malaysia-Hainan-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Laos-
        //Vietnam-Cambodia-Myanmar-Thailand-Hainan-Malaysia-Singapore-Indonesia-Sri Lanka-Kochi-Thailand-Laos-
        //Vietnam-Cambodia-Myanmar-Malaysia-Hainan-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Laos-
        //Vietnam-Cambodia-Myanmar-Thailand-Hainan-Singapore-Malaysia-Indonesia-Sri Lanka-Kochi-Thailand-Laos-
        //Kochi-Thailand-Cambodia-Vietnam-Laos-Myanmar-Indonesia-Malaysia-Singapore-Hainan-Thailand-Sri Lanka-
        //Kochi-Thailand-Cambodia-Vietnam-Laos-Myanmar-Indonesia-Singapore-Malaysia-Hainan-Thailand-Sri Lanka-
        /// </summary>
        public XXXAllDestinationsRuleContainer()
        {

            //rules.Add(new MustStartCountries(new List<char> { 'T', 'M', 'H' }));

            //Empieza la ruta en Tailandia en Abril
            //rules.Add(new MustStartCountries(new List<char> { 'T' }, Month.april));

            //Debo estar el mes de Octubre en Hainan
            //rules.Add(new MustStartCountries(new List<char> { 'H' }, Month.oct));

            //El viaje desde Haikou debe continuar a Tailandia, Malasia o Singapur y añadimos Hanoi por cercania
            rules.Add(new OrCondition(new List<IRule> {
                new CountryBMustFollowCountryA('H', 'T', false), //Por conexiones
                new CountryBMustFollowCountryA('H', 'M', false),
                new CountryBMustFollowCountryA('H', 'G', false) ,
                new CountryBMustFollowCountryA('H', 'V', false) //Por cercania
            }));

            //Conexiones Bloqueadas con Hainan            
            rules.Add(new BlockConnection('K', 'H', false));
            rules.Add(new BlockConnection('S', 'H', false));
            rules.Add(new BlockConnection('B', 'H', false));
            rules.Add(new BlockConnection('I', 'H', false));
            rules.Add(new BlockConnection('B', 'H', false));
            rules.Add(new BlockConnection('L', 'H', false));
            rules.Add(new BlockConnection('C', 'H', false));

            rules.Add(new BlockConnection('V', 'S', false));
            rules.Add(new BlockConnection('V', 'K', false));
            rules.Add(new BlockConnection('L', 'S', false));
            rules.Add(new BlockConnection('L', 'K', false));
            rules.Add(new BlockConnection('C', 'S', false));
            rules.Add(new BlockConnection('C', 'K', false));
            rules.Add(new BlockConnection('B', 'S', false));
            rules.Add(new BlockConnection('B', 'K', false));


            //Conexiones con Indonesia
            rules.Add(new OrCondition(new List<IRule> {
                new CountryBMustFollowCountryA('I', 'G', false), //Por conexiones
                new CountryBMustFollowCountryA('I', 'M', false),
                new CountryBMustFollowCountryA('I', 'T', false),//Por conexiones
                new CountryBMustFollowCountryA('I', 'W', false),
                new CountryBMustFollowCountryA('I', 'N', false),//Por conexiones
            }));

            //Debe tener segmento Sri Lanka - Kochi o Kochi - Sri Lanka
            //Rules.Add(new MustBeConsecutive('S', 'K', false));

            rules.Add(new CountryBMustFollowCountryA('L', 'V', false));
            rules.Add(new CountryBMustFollowCountryA('V', 'C', false));
            rules.Add(new CountryBMustFollowCountryA('M', 'G', false));

            //Duracion de las estancias
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('G', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('C', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('L', 1));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('V', 2));
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('I', 2));

            //No mas de tres meses en Malaysia
            rules.Add(new TotalStayinYearMustBeLessThanXMonth('M', 2));

            rules.Add(new OrCondition(new List<IRule> {
                //new MustBeConsecutive('M', 'S', false),
                new CountryBMustFollowCountryA('M', 'K', false),
                //new MustBeConsecutive('T', 'S', false),
                new CountryBMustFollowCountryA('T', 'K', false),
                new CountryBMustFollowCountryA('N', 'K', false),
                new CountryBMustFollowCountryA('W', 'K', false)
            }));


            rules.Add(new BlockConnection('I', 'V', false));
            rules.Add(new BlockConnection('I', 'L', false));
            rules.Add(new BlockConnection('I', 'C', false));
            rules.Add(new BlockConnection('I', 'K', false));

            rules.Add(new BlockConnection('L', 'M', false));
            rules.Add(new BlockConnection('L', 'W', false));

            rules.Add(new BlockConnection('C', 'W', false));
            rules.Add(new BlockConnection('C', 'M', false));




            rules.Add(new MustConsiderWeather(new List<RangeIntWithDictionary> {
                new RangeIntWithDictionary { Id = 'V',  Values = new List<int> { 1,1,1,1,-1,-1,-1,-1,-1,-1,-1,-1 } } ,
                new RangeIntWithDictionary { Id = 'L', Values = new List<int> { 1, 1, -1,-1,1,1,1,-1,-1, 1, 1, 1 } } ,
                new RangeIntWithDictionary{ Id = 'M',  Values = new List<int> { -1, -1, 1,1,1,1,1,1,1, -1,- 1,- 1 } } ,
                new RangeIntWithDictionary { Id = 'T',  Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,-1, -1, 1, 1 } } ,
                new RangeIntWithDictionary { Id = 'C',  Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,1, 1, 1, 1 } } ,
                new RangeIntWithDictionary{ Id = 'I',  Values = new List<int> { -1, -1, -1,-1,1,1,1,1,1, -1, -1, -1 } } ,
                new RangeIntWithDictionary { Id = 'H',  Values = new List<int> { 1, 1, 1,1,1,-1,-1,-1,-1, 1, 1, 1 } } ,
                new RangeIntWithDictionary { Id = 'S',  Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,1, -1, -1, 1 } } ,
                new RangeIntWithDictionary { Id = 'G', Values = new List<int> { -1, -1, 1,1,1,1,1,1,1, -1, -1, -1 } } ,
                new RangeIntWithDictionary { Id = 'K', Values = new List<int> { 1, 1, 1,1,-1,-1,-1,-1,-1, 1, 1, 1 } } ,

            }));



        }
        public void AddRule(IRule rule)
        {

            rules.Add(rule);

        }
        public List<IRule> GetRules()
        {
            return this.rules;
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
    }

}