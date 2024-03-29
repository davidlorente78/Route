﻿using System;
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
            this.vector = ruleContainer.Vector;
            this.ruleContainer = ruleContainer;

        }
        public List<IRule> Rules
        {
            get { return ruleContainer.GetRules(); }

        }

        public List<List<char>> Generate(int Months)
        {
            CombinationGenerator combinationGenerator = new CombinationGenerator();

            //Reducimos a 11 por Out of Memory

            IEnumerable<IEnumerable<char>> result = combinationGenerator.Generate(this.vector, Months);           

            int count = result.Count();

            List<List<char>> routes = new List<List<char>>();
                   
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
