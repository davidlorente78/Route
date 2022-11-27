using Domain.Ranges;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traveller.Domain;

namespace RouteDataManager.ViewModels
{
    public class AnualItineraryByMonthIndexViewModel
    {
       
        public AnualItineraryByMonthIndexViewModel() 
        {
            var check = 0;
        }

        public List<string> RulesReport { get; set; } = new List<string>();

        public List <string> CountryReport { get; set; } = new List<string>();

        public Traveller.Domain.Country FilterCountry1 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry2 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry3 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry4 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry5 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry6 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry7 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry8 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry9 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry10 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry11 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public Traveller.Domain.Country FilterCountry12 { get; set; } = new Traveller.Domain.Country() { CountryID = 1 };

        public List <Month> Months { get; set; }

        public SelectList SelectListCountries1 { get; set; }

        public SelectList SelectListCountries2 { get; set; }

        public SelectList SelectListCountries3 { get; set; }

        public SelectList SelectListCountries4 { get; set; }

        public SelectList SelectListCountries5 { get; set; }

        public SelectList SelectListCountries6 { get; set; }

        public SelectList SelectListCountries7 { get; set; }

        public SelectList SelectListCountries8 { get; set; }

        public SelectList SelectListCountries9 { get; set; }

        public SelectList SelectListCountries10 { get; set; }

        public SelectList SelectListCountries11 { get; set; }

        public SelectList SelectListCountries12 { get; set; }

    }
}
