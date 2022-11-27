using Domain.Ranges;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RouteDataManager.ViewModels
{
    public class ItineraryByMonthIndexViewModel
    {

        public ItineraryByMonthIndexViewModel()
        {
            
        }

        public int ItineraryMonths { get; set; }

        public Month FilterStartMonth { get; set; } = new Month() { Name = "October", MonthID = 10 }; //Enero es 1 en Base de Datos

        public SelectList SelectListStartMonth { get; set; }

        public Month FilterEndMonth { get; set; } = new Month() { Name = "December", MonthID = 12 };

        public SelectList SelectListEndMonth { get; set; }

        public List<string> RulesReport { get; set; } = new List<string>();

        public int  RoutesFoundCount { get; set; }

        public List<string> CountryReport { get; set; } = new List<string>();

        public Traveller.Domain.Country FilterCountry1 { get; set; } 

        public Traveller.Domain.Country FilterCountry2 { get; set; }

        public Traveller.Domain.Country FilterCountry3 { get; set; }

        public Traveller.Domain.Country FilterCountry4 { get; set; }

        public Traveller.Domain.Country FilterCountry5 { get; set; } 

        public Traveller.Domain.Country FilterCountry6 { get; set; } 

        public Traveller.Domain.Country FilterCountry7 { get; set; }

        public Traveller.Domain.Country FilterCountry8 { get; set; } 

        public Traveller.Domain.Country FilterCountry9 { get; set; } 

        public Traveller.Domain.Country FilterCountry10 { get; set; } 

        public Traveller.Domain.Country FilterCountry11 { get; set; } 

        public Traveller.Domain.Country FilterCountry12 { get; set; } 

        public List<Month> Months { get; set; }

        public int ShowingIndex { get; set; }
        

    }
}
