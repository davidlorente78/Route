using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.ViewModels;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;


//using RouteDataManager.Repositories; Solved
namespace RouteDataManager.Controllers
{
    /// <summary>
    /// Los nombres de los controlodores empiezan por el nombre en singular de la entidad
    /// </summary>
    public class CountryController : Controller
    {
        private readonly ICountryService  countryService;
         
        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        public IActionResult Index(int? id)
        {
            var viewModel = new CountryIndexData();

            //TODO Mapeo entre entidades de dominio y entidades del modelo de la vista

            ICollection<Country>? countries = countryService.GetAllCountries();

            viewModel.Countries = countries;                

            if (id != null)
            {
                ViewBag.CountryId = id.Value;

                var selectedCountryDestinations = countries.Single(c => c.CountryID == id.Value).Destinations.OrderBy(c=>c.Country.Name);
                var selectedCountryFrontiers = countries.Single(c => c.CountryID == id.Value).BorderCrossings;
                var selectedCountryVisas = countries.Single(c => c.CountryID == id.Value).Visas;

               
                viewModel.Destinations = selectedCountryDestinations;
                viewModel.Frontiers = selectedCountryFrontiers;
                viewModel.Visas = selectedCountryVisas;
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            CountryDto countryDto = countryService.GetCountry((int)id);
           

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

            Country country = countryService.GetCountryByID((int)id);

            if (country == null)
            {
                return NotFound();
            }
            return PartialView(country);
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
            if (id == null ||  countryService.CountryExists((int)id) == false)
            {
                return NotFound();
            }

            Country country = countryService.GetCountryByID((int)id);
            if (country == null)
            {
                return NotFound();
            }

            return View(country);
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
            Country country = countryService.GetCountryByID((int)id);

            if (country != null)
            {
                countryService.RemoveCountry(country);
            }

            return RedirectToAction(nameof(Index));
        }

   

    }

  
}
