using Application.Dto;
using DomainServices.DestinationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.Models;
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
        private readonly IWebHostEnvironment environment;

        private readonly ICountryService countryService;
        private readonly IDestinationService destinationService;
        private readonly IDestinationTypeService destinationTypeService;

        private IEnumerable<CountryDto> countries;
        private IEnumerable<DestinationDto> destinations;
        private IEnumerable<DestinationTypeDto> destinationTypes;

        public DestinationsController(
            ICountryService countryService,
            IDestinationService destinationService,
            IDestinationTypeService destinationTypeService,
            IWebHostEnvironment environment
            )
            : base(destinationService)
        {

            this.countryService = countryService;
            this.destinationService = destinationService;
            this.destinationTypeService = destinationTypeService;

            countries = countryService.GetAll();
            destinations = destinationService.GetAll();
            destinationTypes = destinationTypeService.GetAll();

            //Se utiliza para Path de Picture Asociada
            this.environment = environment;
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
                d => d.DestinationCountryID == destinationIndexViewModel.FilterCountry.Id && d.DestinationTypes.Select(d => d.Id).Contains(destinationIndexViewModel.FilterDestinationType.Id),
                d => d.DestinationCountry, d => d.DestinationTypes);

            destinationIndexViewModel.Destinations = destinations;
            destinationIndexViewModel.SelectListCountries = new SelectList(countries, "Id", "Name", destinationIndexViewModel.FilterCountry.Id); ;
            destinationIndexViewModel.SelectListDestinationTypes = new SelectList(destinationTypes, "Id", "Description", destinationIndexViewModel.FilterDestinationType.Id);


            return (View("Index", destinationIndexViewModel));
        }

        public override IActionResult Details(int? id)
        {
            var destination = destinationService.GetIncluding(
               d => d.Id == id,
               d => d.DestinationCountry, d => d.DestinationTypes)
            .FirstOrDefault();

            if (destination == null)
            {
                return NotFound();
            }

            return PartialView(destination);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DestinationViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model.Picture);
                DestinationDto destination = new()
                {
                    DestinationCountryID = model.CountryID,
                    Name = model.Name,
                    Description = model.Description,
                    Picture = uniqueFileName
                };

                destinationService.Add(destination);
                return RedirectToAction(nameof(Index));
            }

            return PartialView(model);
        }

        public override IActionResult Edit(int? id)
        {
            var destination = destinationService.GetIncluding(
              d => d.Id == id,
              d => d.DestinationCountry, d => d.DestinationTypes, d => d.Stations)
            .FirstOrDefault();


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

            return PartialView(destinationViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //Edit y Create reciben como parametro el ViewModel y en Cambio el Repositorio Generico trabaja con Dto
        //En este mismo metodo se realiza la transformacion TODO
        public IActionResult EditWithPicture(DestinationViewModel model)
        {
            try
            {
                var destination = destinationService.GetByID(model.DestinationID);

                destination.Name = model.Name;
                destination.Description = model.Description;
                destination.DestinationCountryID = model.CountryID;

                if (model.Picture != null)
                {
                    if (model.ExistingImage != null)
                    {
                        string filePath = Path.Combine(environment.WebRootPath, "Uploads", model.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    destination.Picture = ProcessUploadedFile(model.Picture);
                }

                destinationService.Update(destination);

                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (destinationService.GetByID(model.Id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }

        private string ProcessUploadedFile(IFormFile formFile)
        {
            string uniqueFileName = string.Empty;
            string path = Path.Combine(environment.WebRootPath, DestinationFileLocation.FileUploadFolder);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (formFile != null)
            {
                string uploadsFolder = Path.Combine(environment.WebRootPath, DestinationFileLocation.FileUploadFolder);
                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
