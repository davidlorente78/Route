using Application.Dto;
using RouteDataManager.Controllers.Generic;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class CountriesController : GenericController<CountryDto, Country>
    {

        public CountriesController(ICountryService countryService) : base(countryService)
        {
        }

        //public override IActionResult Index(int? id)
        //{
        //    var countryIndexViewModel = new CountryIndexViewModel();

        //    ICollection<CountryDto>? countries = genericService.GetAll();

        //    countryIndexViewModel.Countries = countries;

        //    if (id != null)
        //    {
        //        ViewBag.CountryId = id.Value;
        //    }

        //    return View(countryIndexViewModel);
        //}     
    }
}
