using Domain.Transport.Aviation;
using DomainServices.Generic;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.Models;
using RouteDataManager.ViewModels.Airline;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class AirlinesController : GenericController<AirlineDto, Airline>
    {
        private readonly IWebHostEnvironment _environment;

        private readonly IAirlineService airlinesService;
        private readonly IGenericService<AirlineTypeDto, AirlineType> airlineTypeService;


        public AirlinesController(
            IWebHostEnvironment environment,
            IAirlineService airlinesService,
            IGenericService<AirlineTypeDto, AirlineType> airlineTypeService,
            IPublishEndpoint publishEndpoint) : base(airlinesService, publishEndpoint)

        {
            _environment = environment;
            this.airlinesService = airlinesService;
            this.airlineTypeService = airlineTypeService;
        }

        public override IActionResult Create()
        {
            var airlineTypes = airlineTypeService.GetAll();

            var airlineViewModel = new AirlineViewModel()
            {
                SelectListAirlineTypes = new SelectList(airlineTypes, "Id", "Description", airlineTypes.First().Id),
                AirlineTypeID = airlineTypes.First().Id
            };

            return View(airlineViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateWithPicture(AirlineViewModel model)
        {
            string uniqueFileName = ProcessUploadedFile(model.MapPicture);
            AirlineDto airline = new()
            {
                Name = model.Name,
                Description = model.Description,
                Picture = uniqueFileName,
            };

            airlinesService.Add(airline);
            return RedirectToAction(nameof(Index));
        }

        public override IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airline = airlinesService.GetById(id.Value);

            if (airline == null)
            {
                return NotFound();
            }

            var airlineTypes = airlineTypeService.GetAll();

            var airlineViewModel = new AirlineViewModel()
            {
                Id = airline.Id,
                Name = airline.Name,
                Description = airline.Description,
                ExistingImage = airline.Picture,
                SelectListAirlineTypes = new SelectList(airlineTypes, "Id", "Description", airline.AirlineTypeID),
                AirlineTypeID = airline.AirlineTypeID 
            };

            return View(airlineViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditWithPicture(AirlineViewModel model)
        {
            var airline = airlinesService.GetById(model.Id);

            airline.Name = model.Name;
            airline.Description = model.Description;

            if (model.MapPicture != null)
            {
                if (model.ExistingImage != null)
                {
                    string filePath = Path.Combine(_environment.WebRootPath, AirlineFileLocation.FileUploadFolder, model.ExistingImage);
                    System.IO.File.Delete(filePath);
                }

                airline.Picture = ProcessUploadedFile(model.MapPicture);
            }

            airlinesService.Update(airline);

            return RedirectToAction(nameof(Index));
        }

        private string ProcessUploadedFile(IFormFile formFile)
        {
            string uniqueFileName = string.Empty;
            string path = Path.Combine(_environment.WebRootPath, AirlineFileLocation.FileUploadFolder);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (formFile != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, AirlineFileLocation.FileUploadFolder);
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
