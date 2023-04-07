using Data.EntityTypes;
using DomainServices.DestinationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.Models;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using RouteDataManager.ViewModels.Destination;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    /// <summary>
    /// https://stackoverflow.com/questions/5849398/mvc-3-form-post-and-persisting-model-data
    /// </summary>
    public class DestinationsController : GenericController<DestinationDto, Destination>
    {
        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment _environment;

        private readonly ICountryService countryService;
        private readonly IDestinationService destinationService;
        private readonly IDestinationTypeService destinationTypeService;


        private IEnumerable<CountryDto> countries;
        private IEnumerable<DestinationDto> destinations;
        private IEnumerable<DestinationTypeDto> destinationTypes;


        public DestinationsController(     
            ICountryService countryService,
            IDestinationService destinationService,
            IDestinationTypeService destinationTypeService
            ) 
            : base(destinationService)
        {
           
            this.countryService = countryService;
            this.destinationService = destinationService;
            this.destinationTypeService = destinationTypeService;

            countries = countryService.GetAll();
            destinations = destinationService.GetAll();
            destinationTypes = destinationTypeService.GetAll();
        }

        [HttpGet]
        public IActionResult Index(DestinationIndexViewModel destinationIndexViewModel)
        {
            if (destinationIndexViewModel is null)
            {
                throw new ArgumentNullException(nameof(destinationIndexViewModel));
            }

            var destinations = destinationService.GetIncluding(
                d => d.DestinationCountryID == destinationIndexViewModel.FilterCountry.Id && d.DestinationTypes.Select(d => d.Id).Contains(destinationIndexViewModel.FilterDestinationType.Id),
                d => d.DestinationCountry, d => d.DestinationTypes);


            SelectList selectListCountries = new SelectList(countries, "Id", "Name", destinationIndexViewModel.FilterCountry.Id);
            SelectList selectListDestinationTypes = new SelectList(destinationTypes, "Id", "Description", destinationIndexViewModel.FilterDestinationType.Id);

            destinationIndexViewModel.SelectListCountries = selectListCountries;
            destinationIndexViewModel.SelectListDestinationTypes = selectListDestinationTypes;

            destinationIndexViewModel.Destinations = destinations;

            return (View(destinationIndexViewModel));
        }

        [HttpPost]
        public IActionResult Results(DestinationIndexViewModel destinationIndexViewModel)
        {
            if (destinationIndexViewModel is null)
            {
                throw new ArgumentNullException(nameof(destinationIndexViewModel));
            }

            var destinations = destinationService.GetIncluding(
                d => d.DestinationCountryID == destinationIndexViewModel.FilterCountry.Id &&  d.DestinationTypes.Select(d => d.Id).Contains(destinationIndexViewModel.FilterDestinationType.Id),
                d => d.DestinationCountry, d => d.DestinationTypes);

            destinationIndexViewModel.Destinations = destinations;
            destinationIndexViewModel.SelectListCountries = new SelectList(countries, "Id", "Name", destinationIndexViewModel.FilterCountry.Id); ;
            destinationIndexViewModel.SelectListDestinationTypes = new SelectList(destinationTypes, "Id", "Description", destinationIndexViewModel.FilterDestinationType.Id);
          

            return (View("Index", destinationIndexViewModel));
        }

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

        public IActionResult Create()
        {
            ViewData["CountryID"] = new SelectList(countries, "Id", "Name");
            return PartialView();
        }

       
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
