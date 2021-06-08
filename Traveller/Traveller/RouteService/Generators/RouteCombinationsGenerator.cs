using System;
using System.Collections.Generic;
using Traveller.Domain;
using Traveller.RouteService;
using Traveller.RuleService;
using System.Linq;
using Traveller.RouteService.Evaluator;
using Traveller.RouteService.Helpers;

namespace Traveller
{
    public class RouteCombinationsGenerator : IRouteGenerator
    {
        private List<char> vector;
        private IRuleContainer ruleContainer;
       
        public RouteCombinationsGenerator( IRuleContainer ruleContainer,List<char> vector) 
        {
            //El vector de Rule Container es ignorado
            this.vector = vector;
            this.ruleContainer = ruleContainer;
           
        }
        public List<IRule>  Rules
        {
            get { return ruleContainer.GetRules(); }

        }
        public List<List<char>>  Generate()
        {
            CombinationGenerator combinationGenerator = new CombinationGenerator();

            IEnumerable<IEnumerable<char>> result = combinationGenerator.Generate(this.vector, 12);

            //int count = result.Count();          

            List<List<char>> routes = new List<List<char>>();
            foreach (IEnumerable<char> r in result) {

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
