using DomainServices.DestinationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Models;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using RouteDataManager.ViewModels.Destination;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment _environment;

        private readonly ICountryService countryService;
        private readonly IDestinationService destinationService;

        private IEnumerable<CountryDto> countries;
        private IEnumerable<DestinationDto> destinations;

        public DestinationsController(
            ApplicationContext context,
            IWebHostEnvironment environment,
            ICountryService countryService,
            IDestinationService destinationService)
        {
            _context = context;
            _environment = environment;
            this.countryService = countryService;
            this.destinationService = destinationService;

            countries = countryService.GetAll();
            destinations = destinationService.GetAll();

        }

        // GET: Destinations
        public async Task<IActionResult> Index(DestinationIndexViewModel destinationIndexViewModel)
        {
            IOrderedQueryable<Destination>? applicationContext;

            if (destinationIndexViewModel.FilterCountry.Id != 0)
            {
                applicationContext = _context.Destinations
                    .Where(
                        d => d.DestinationCountryID == destinationIndexViewModel.FilterCountry.Id
                        &&
                        d.DestinationTypes.Select(d => d.DestinationTypeID).Contains(destinationIndexViewModel.FilterDestinationType.DestinationTypeID)
                     )
                    .Include(d => d.DestinationCountry)
                    .Include(d => d.DestinationTypes)
                    .OrderBy(d => d.Name);
            }
            else
            {
                applicationContext = _context.Destinations.Include(d => d.DestinationCountry).Include(d => d.DestinationTypes).OrderBy(d => d.Name);
            }

            SelectList selectListCountries = new SelectList(countries, "Id", "Name", destinationIndexViewModel.FilterCountry.Id);
            SelectList selectListDestinationTypes = new SelectList(_context.DestinationTypes, "DestinationTypeID", "Description", destinationIndexViewModel.FilterDestinationType.DestinationTypeID);

            destinationIndexViewModel.SelectListCountries = selectListCountries;
            destinationIndexViewModel.SelectListDestinationTypes = selectListDestinationTypes;

            List<Traveller.Domain.Destination>? destinations = await applicationContext.ToListAsync();

            destinationIndexViewModel.Destinations = destinations;

            return PartialView(destinationIndexViewModel);
        }

        // GET: Destinations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Destinations == null)
            {
                return NotFound();
            }

            var destination = await _context.Destinations
                .Include(d => d.DestinationCountry).Include(d => d.DestinationTypes)
                .FirstOrDefaultAsync(m => m.Id == id);



            if (destination == null)
            {
                return NotFound();
            }

            ViewData["CountryID"] = new SelectList(countries, "Id", "Name", destination.DestinationCountryID);

            return PartialView(destination);
        }

        // GET: Destinations/Create
        public IActionResult Create()
        {
            ViewData["CountryID"] = new SelectList(countries, "Id", "Name");
            return PartialView();
        }

        // POST: Destinations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DestinationViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                Destination destination = new()
                {
                    DestinationCountryID = model.CountryID,
                    Name = model.Name,
                    Description = model.Description,
                    Picture = uniqueFileName
                };

                _context.Add(destination);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CountryID"] = new SelectList(countries, "Id", "Name", model.CountryID);

            return PartialView(model);
        }

        // GET: Destinations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Destinations == null)
            {
                return NotFound();
            }

            var destination = await _context
                .Destinations
                .Include(d => d.DestinationCountry)
                .Include(d => d.DestinationTypes)
                .Include(d => d.Stations)
                .FirstAsync(d => d.Id == id);

            if (destination == null)
            {
                return NotFound();
            }

            var destinationViewModel = new DestinationViewModel()
            {
                CountryID = destination.DestinationCountryID,
                DestinationID = destination.Id,
                Description = destination.Description,
                Id = destination.Id,
                Name = destination.Name,
                ExistingImage = destination.Picture,

            };

            ViewData["CountryID"] = new SelectList(countries, "Id", "Name", destination.DestinationCountryID);
            return PartialView(destinationViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, DestinationViewModel model)
        {
            //???
            if (id != model.Id)
            {
                return NotFound();
            }

            try
            {
                //Se recupera de la base de datos
                var destination = await _context.Destinations.FindAsync(model.Id);

                //Se actualizan los datos entrantes desde el modelo
                destination.Name = model.Name;
                destination.Description = model.Description;
                destination.DestinationCountryID = model.CountryID;


                if (model.Picture != null)
                {
                    if (model.ExistingImage != null)
                    {
                        string filePath = Path.Combine(_environment.WebRootPath, "Uploads", model.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    destination.Picture = ProcessUploadedFile(model);
                }
                _context.Update(destination);
                await _context.SaveChangesAsync();
                ViewData["CountryID"] = new SelectList(countries, "Id", "Name", model.CountryID);

                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinationExists(model.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        // GET: Destinations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Destinations == null)
            {
                return NotFound();
            }

            var destination = await _context.Destinations
                .Include(d => d.DestinationCountry)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (destination == null)
            {
                return NotFound();
            }

            return PartialView(destination);
        }

        // POST: Destinations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Destinations == null)
            {
                return Problem("Entity set 'ApplicationContext.Destinations'  is null.");
            }
            var destination = await _context.Destinations.FindAsync(id);
            if (destination != null)
            {
                _context.Destinations.Remove(destination);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestinationExists(int id)
        {
            return (_context.Destinations?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private string ProcessUploadedFile(DestinationViewModel model)
        {
            string uniqueFileName = null;
            string path = Path.Combine(_environment.WebRootPath, DestinationFileLocation.FileUploadFolder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (model.Picture != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, DestinationFileLocation.FileUploadFolder);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Picture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Picture.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
