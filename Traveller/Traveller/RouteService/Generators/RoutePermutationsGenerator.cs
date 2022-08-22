using System;
using System.Collections.Generic;
using Traveller.Domain;
using Traveller.RouteService;
using Traveller.RouteService.Helpers;
using Traveller.RuleService;

namespace Traveller
{
    public class RoutePermutationsGenerator : IRouteGenerator
    {
        private List<char> vector;
        private IRuleContainer ruleContainer;

        public RoutePermutationsGenerator(IRuleContainer ruleContainer)
        {
            this.vector = ruleContainer.Vector;
            this.ruleContainer = ruleContainer;

        }
        public List<IRule> Rules
        {
            get { return ruleContainer.GetRules(); }

        }
        public List<List<char>> Generate()
        {

            List<char[]> permutes = PermuteGenerator.Generate(vector);
            int count = permutes.Count;

            Console.WriteLine("Permutaciones calculadas");

            List<List<char>> result = new List<List<char>>();

            //Inicializar Reglas de Viaje           
            List<IRule> rules = ruleContainer.GetRules();
            RouteValidator routeValidator = new RouteValidator(rules);


            for (int month = 0; month < 12; month++)
            {

                foreach (char[] chararray in permutes)
                {

                    List<char> routeChar = new List<char>();
                    foreach (char ch in chararray)
                    {
                        routeChar.Add(ch);
                    }

                    routeChar.Insert(month, 'X');

                    List<List<char>> suggested_X = new List<List<char>>();

                    if (routeValidator.Validate(routeChar))
                    {
                        List<List<char>> routes_with_monthly_destinations = new List<List<char>>();
                        List<char> MonthOptions = ruleContainer.GetDestinationByMonth(month);
                        //MonthOptions = new List<char> { 'M', 'T' }; 
                        routeChar.Remove('X');

                        foreach (char countryCode in MonthOptions)
                        {
                            List<char> newroute = new List<char>();
                            foreach (char ch in routeChar) newroute.Add(ch);
                            newroute.Insert(month, countryCode);
                            routes_with_monthly_destinations.Add(newroute);
                        }


                        foreach (List<char> route in routes_with_monthly_destinations)
                        {
                            if (routeValidator.Validate(route))
                            {

                                result.Add(route);
                                foreach (char countryCode in route)
                                {
                                    Console.Write(CodeDictionary.GetCountryByCode(countryCode) + "-");
                                }

                                Console.WriteLine();



                            }
                        }

                    }

                }

            }

            return Helper.DeleteDuplicates(result);

        }

    }
}
