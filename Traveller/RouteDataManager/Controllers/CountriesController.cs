using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.ViewModels.Country;
using Traveller.Application.Dto;
//using Traveller.Domain;
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

            ICollection<CountryDto>? countries = countryService.GetAllCountries();

            countryIndexViewModel.Countries = countries;

            if (id != null)
            {
                ViewBag.CountryId = id.Value;
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
        public async Task<IActionResult> Create([Bind("CountryID,Code,Name")] CountryDto countryDto)
        {
            if (ModelState.IsValid)
            {
                countryService.AddCountry(countryDto);

                return RedirectToAction(nameof(Index));
            }
            return PartialView(countryDto);
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
        public async Task<IActionResult> Edit(int id, [Bind("CountryID,Code,Name")] CountryDto countryDto)
        {
            if (id != countryDto.CountryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    countryService.UpdateCountry(countryDto);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!countryService.CountryExists(countryDto.CountryID))
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
            return View(countryDto);
        }

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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            CountryDto countryDto = countryService.GetCountryByID((int)id);

            if (countryDto != null)
            {
                countryService.RemoveCountry(countryDto.CountryID);
            }
            else
            {
                return Problem("Country does not exist.");
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
