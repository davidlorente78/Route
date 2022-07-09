using System;
using System.Collections.Generic;
using System.Linq;
using Traveller.Domain;
using Traveller.RouteService;
using Traveller.RouteService.Helpers;
using Traveller.RuleService;

namespace Traveller
{
    public class RouteCombinationsGenerator : IRouteGenerator
    {
        private List<char> vector;
        private IRuleContainer ruleContainer;

        public RouteCombinationsGenerator(IRuleContainer ruleContainer)
        {
            this.vector = ruleContainer.GetVector();
            this.ruleContainer = ruleContainer;

        }
        public List<IRule> Rules
        {
            get { return ruleContainer.GetRules(); }

        }
        public List<List<char>> Generate()
        {
            CombinationGenerator combinationGenerator = new CombinationGenerator();

            //Reducimos a 11 por Out of Memory

            IEnumerable<IEnumerable<char>> result = combinationGenerator.Generate(this.vector, 11);

           

            int count = result.Count();

            List<List<char>> routes = new List<List<char>>();
            foreach (IEnumerable<char> r in result)
            {
                foreach (char c in vector) {
                    var append = r.Append(c);
                    List<char> rList = r.ToList();
                    routes.Add(rList);

                }

            }


         
            foreach (IEnumerable<char> r in result)
            {

                List<char> rList = r.ToList();
                routes.Add(rList);

            }




            List<List<char>> filterresult = new List<List<char>>();

            //Inicializar Reglas de Viaje           
            List<IRule> rules = ruleContainer.GetRules();
            RouteValidator routeValidator = new RouteValidator(rules);


            foreach (List<char> route in routes)
            {
                if (routeValidator.Validate(route))
                {

                    foreach (char c in vector)
                    {
                        IEnumerable<char> append = route.Append(c);
                        List<char> appendList = append.ToList();

                        if (routeValidator.Validate(appendList))
                        {
                            filterresult.Add(appendList);
                        }

                    }



                    filterresult.Add(route);
                    foreach (char countryCode in route)
                    {
                        Console.Write(CodeDictionary.GetCountryByCode(countryCode) + "-");
                    }

                    Console.WriteLine();

                }
            }



            return Helper.DeleteDuplicates(filterresult);

        }

    }
}
