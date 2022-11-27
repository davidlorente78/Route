using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.ViewModels.Country;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;


//using RouteDataManager.Repositories; Solved
namespace RouteDataManager.Controllers
{

    public class CountriesController : Controller
    {
        private readonly ICountryService countryService;

        public CountriesController(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        public IActionResult Index(int? id)
        {
            var countryIndexViewModel = new CountryIndexViewModel();

            //TODO Mapeo entre entidades de dominio y entidades del modelo de la vista

            ICollection<CountryDto>? countries = countryService.GetAllCountries();

            countryIndexViewModel.Countries = countries;

            if (id != null)
            {
                ViewBag.CountryId = id.Value;

                //TODO Pendiente ajustar a Dto y Mapper

                //var selectedCountryDestinations = countries.Single(c => c.CountryID == id.Value).Destinations.OrderBy(c => c.Country.Name);
                //var selectedCountryFrontiers = countries.Single(c => c.CountryID == id.Value).BorderCrossings;
                //var selectedCountryVisas = countries.Single(c => c.CountryID == id.Value).Visas;


                //viewModel.Destinations = selectedCountryDestinations;
                //viewModel.BorderCrossings = selectedCountryFrontiers;
                //viewModel.Visas = selectedCountryVisas;
            }
            return View(countryIndexViewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CountryDto countryDto = countryService.GetCountryByID((int)id);


            if (countryDto == null)
            {
                return NotFound();
            }

            return View(countryDto);
        }

        // GET: Countries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Countries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CountryID,Code,Name")] Country country)
        {
            //HERE
            //country.Frontiers = null;
            country.Destinations = null;

            if (ModelState.IsValid)
            {
                countryService.AddCountry(country);

                return RedirectToAction(nameof(Index));
            }
            return PartialView(country);
        }

        // GET: Countries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || countryService.CountryExists((int)id) == false)
            {
                return NotFound();
            }

            CountryDto countryDto = countryService.GetCountryByID((int)id);

            if (countryDto == null)
            {
                return NotFound();
            }
            return PartialView(countryDto);
        }

        // POST: Countries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CountryID,Code,Name")] Country country)
        {
            if (id != country.CountryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    countryService.UpdateCountry(country);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!countryService.CountryExists(country.CountryID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        // GET: Countries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || countryService.CountryExists((int)id) == false)
            {
                return NotFound();
            }

            CountryDto countryDto = countryService.GetCountryByID((int)id);
            if (countryDto == null)
            {
                return NotFound();
            }

            return View(countryDto);
        }

        // POST: Countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (countryService.CountryExists((int)id) == false)
            {
                return Problem("Country does not exist.");
            }

            CountryDto countryDto = countryService.GetCountryByID((int)id);

            if (countryDto != null)
            {
                countryService.RemoveCountry(countryDto);
            }

            return RedirectToAction(nameof(Index));
        }



    }


}
