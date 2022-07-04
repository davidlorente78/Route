using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
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
        //private readonly IUnitOfWork unitOfWork;

        //EN ESTA CLASE ESTAN MEZCLADAS EL ACCESO POR SERVICIO Y ACCESO POR CONTEXTO

        //TODO
        //InvalidOperationException: Unable to resolve service for type 'Traveller.RouteService.CountryService' while attempting to activate 'RouteDataManager.Controllers.CountryController'.
        //Microsoft.Extensions.DependencyInjection.ActivatorUtilities.GetService(IServiceProvider sp, Type type, Type requiredBy, bool isDefaultParameterRequired)

        /// <summary>
        /// Here are injecting only the IUnitOfWork object. This way, you can completely avoid writing lines and lines of injections to your controllers.
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// 
        public CountryController(ICountryService countryService, IUnitOfWork   unitOfWork)
        {
            this.countryService = countryService;
            //this.unitOfWork = unitOfWork;
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

                var selectedCountryDestinations = countries.Single(c => c.CountryID == id.Value).Destinations;
                //var selectedCountryFrontiers = countries.Single(c => c.CountryID == id.Value).Frontiers;
                viewModel.Destinations = selectedCountryDestinations;
                //viewModel.Frontiers = selectedCountryFrontiers;
            }
            return View(viewModel);
            //return View(countries);
         

        }



        // GET: Countries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            Country country = countryService.GetCountryByID((int)id);

            var viewModel = new CountryViewModel();

            viewModel.CountryID = country.CountryID;
            viewModel.Code = country.Code;
            viewModel.Name = country.Name;

            //HERE


            if (country == null)
            {
                return NotFound();
            }

            return View(country);
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
            return View(country);
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
            return View(country);
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
