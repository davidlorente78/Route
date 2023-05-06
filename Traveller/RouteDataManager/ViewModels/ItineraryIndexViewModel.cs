using Domain.Ranges;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RouteDataManager.ViewModels
{
    public class ItineraryIndexViewModel
    {
        public ItineraryIndexViewModel()
        {
            
        }

        public int ItineraryMonths { get; set; }

        public Month FilterStartMonth { get; set; } = new Month() { Name = "December", MonthID = 12 }; //Enero es 1 en Base de Datos

        public SelectList SelectListStartMonth { get; set; }

        public Month FilterEndMonth { get; set; } = new Month() { Name = "February", MonthID = 2 };

        public SelectList SelectListEndMonth { get; set; }

        public List<string> RulesReport { get; set; } = new List<string>();

        public int  RoutesFoundCount { get; set; }

        public List<Traveller.Domain.Country> FilterCountry { get; set; } = new List<Traveller.Domain.Country>();

        public List<string> CountryReport { get; set; } = new List<string>();

        public List<Month> Months { get; set; }

        public int ShowingIndex { get; set; }
    }
}
