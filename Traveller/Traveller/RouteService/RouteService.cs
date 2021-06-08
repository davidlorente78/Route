using System;
using System.Collections.Generic;

namespace Traveller.RouteService
{
    public class RouteService
    {
        Status status;
        public  RouteService(Status status) {

            this.status = status;
        }




        public List<TravellTask> EstimateTask() {


            //TODO 

            int index = this.status.today.Month-1;

            List<char> ActualRoute  = status.ActualRoute;


            Route countryDataService = new Route();
            Country Current = countryDataService.Countries.Find(x => x.Code == ActualRoute[index]);


            int next = index + 1;
            if (next == ActualRoute.Count) next = 0;

            //Actualmente estas en X y te diriges hacia Y
            Country Next = countryDataService.Countries.Find(x => x.Code == ActualRoute[next]);

            string CurrentCountry = Current.Name;

            string NextCountry = Next.Name;

            string CurrentDestination = status.Destination.Name;

            Console.WriteLine(CurrentCountry + " -> " + NextCountry);




            //Report X
            //Report Y

            //Para dirigirte a Y deberias 

            FrontierService frontierService = new FrontierService();

            var Fronteras = frontierService.FrontierstoAccesDestinationFromOriginIncludingAirports(Next.Code, Current.Code);

            foreach (Frontier frontier in Fronteras) {

                Console.WriteLine(frontier.ToString());
            
            }

         



            //Report proxima etapa

            //API Weather

            //Actual 

            //Report 

            //Tu visado aun es valido hasta el dia D

            DateTime ValidTill = status.VisaStamp.ExpiryDate;

            //Tienes la opcion de alargar tu estancia en X pero la ruta se veria alterada. 

            //bool Extensible = status.VisaStamp.Visa.Extensible;

           // if (Extensible) Console.WriteLine("Tienes la opcion de alargar tu estancia");

            //Solicitar Visado para siguiente etapa

            //Seleccionar frontera y aparecen los visados a solicitar

            //ON ARRIVAL
            //ONLINE ETA ... 

            //Billete de entrada 



            //Billete de salida para etapa siguiente etapa



            //Las bases en destino Y donde deberias reservar noches son ... listado


            List <Destination> destinations = Next.Destinations.FindAll(x => x.Type == 'T');//Turist Spot




                      
            return new List<TravellTask>() { };


        
        
        }



    }
}
