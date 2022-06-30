using System;
using System.Collections.Generic;
using Traveller;
using Traveller.Domain;
using Traveller.RouteService;
using Traveller.RouteService.DataContainer;
using Traveller.RouteService.Evaluator;
using Traveller.RuleService;

namespace Nomad
{
    class Program
    {
        static void Main(string[] args)
        {
             //  

             RouteCombinationsGenerator routeGenerator = new RouteCombinationsGenerator(new MalasyaTailandiaBasedRuleWithBaliContainer() { vector = new List<char> { 'M', 'T', 'X', 'I' } });

            var routes = routeGenerator.Generate();

            Console.WriteLine("Rutas encontradas " + routes.Count.ToString());

            RouteEvaluator routeEvaluator = new RouteEvaluator(
              new List<IEvaluator> {
                    new SeasonEvaluator(new SeasonDataContainer ()),
                  }
              );


            foreach (var route in routes)
            {
                var finalReport = routeEvaluator.EvaluateAndReport(route);
                int count = routes.Count;
            }


            //Journey Planner

            //Status status = new Status();

            ////Laos-Vietnam-Cambodia-Thailand-Malaysia-Bali-Malaysia-Indonesia-Malaysia-Penang-Kochi-Chiang Mai-

            //status.ActualRoute = new List<char> { 'L', 'V', 'L', 'T', 'M', 'B', 'M', 'I', 'M', 'W', 'K', 'N' };

            //status.Destination = CambodiaDestinations.Angkor;

            //status.VisaStamp = new VisaStamp
            //{
            //    EntryDate = Convert.ToDateTime("1/3/2001"),
            //    EntryPoint = CambodiaDestinations.Bavet,
            //    IssueDate = Convert.ToDateTime("1/3/2001"),
            //    ExpiryDate = Convert.ToDateTime("28/3/2001")
            //};


            //status.today = DateTime.Today;

            //RouteService routeService = new RouteService(status);
            //var Tas = routeService.EstimateTask();








        }
        static void GenerarRutas()
        {
            ///TODO Check Generatotion
            RoutePermutationsGenerator routeGenerator = new RoutePermutationsGenerator(new MalasyaTailandiaBasedRuleContainer(new List<char> { 'L', 'V', 'C', 'T', 'M', 'B', 'M', 'I', 'M', 'W', 'K', 'N' }));

            //Informar por pantalla de las reglas que se estan aplicando
            foreach (var rule in routeGenerator.Rules)
            {
                Console.WriteLine(rule.ToString());
                Console.WriteLine();
            }

            //Generar las rutas validas 
            List<List<char>> routes = routeGenerator.Generate();

            int count = routes.Count;

        }



        private static void Report(SeasonEvaluator evaluator, List<KeyValuePair<double, List<char>>> evaluatedRoutes)
        {
            if (evaluatedRoutes.Count != 0)
            {

                Console.WriteLine("Mejor evaluacion estacional" + evaluatedRoutes[0].Key);
                Console.WriteLine("Peor evaluacion estacional " + evaluatedRoutes[evaluatedRoutes.Count - 1].Key);
                ///


                foreach (var route in evaluatedRoutes)
                {
                    foreach (char countryCode in route.Value)
                    {
                        Console.Write(CodeDictionary.GetCountryByCode(countryCode) + "-");
                    }

                    Console.WriteLine();

                    //No es necesario que ya lo tengo en la Key de la ordenacion anterior!! TODO

                    double evaluation = evaluator.Evaluate(route.Value);

                    Console.WriteLine(evaluation.ToString());
                    List<Tuple<char, string>> report = evaluator.Report(route.Value);

                    int n = 1;
                    foreach (var m in report)
                    {
                        Console.WriteLine("Mes  " + n.ToString() + " en  " + CodeDictionary.GetCountryByCode(route.Value[n - 1]) + " " + m.Item2);
                        n++;
                    }


                    var line = Console.ReadLine();
                    Console.Clear();

                }

            }
        }
    }
}
