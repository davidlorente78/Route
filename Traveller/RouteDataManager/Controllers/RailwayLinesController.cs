using Domain.Transport.Railway;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.ViewModels;
using RouteDataManager.ViewModels.RailwaySystem;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class RailwayLinesController : GenericController<RailwayLineDto, RailwayLine>
    {
        private ICountryService countryService;
        private IRailwayLineService railwayLineService;
        private IEnumerable<CountryDto> countries;


        public RailwayLinesController(
            ICountryService countryService,
            IRailwayLineService railwayLineService,
            IPublishEndpoint publishEndpoint) : base(railwayLineService, publishEndpoint)
        {
            this.countryService = countryService;
            this.railwayLineService = railwayLineService;

            countries = countryService.GetAll();
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Index(LineIndexViewModel lineIndexViewModel)
        {
            var lines = railwayLineService.GetIncluding(
                d => d.CountryID == lineIndexViewModel.FilterCountry.Id,
                d => d.Country);

            SelectList selectListCountries = new SelectList(countries, "Id", "Name", lineIndexViewModel.FilterCountry.Id);

            lineIndexViewModel.SelectListCountries = selectListCountries;
            lineIndexViewModel.Lines = lines;

            return PartialView(lineIndexViewModel);
        }

        public override IActionResult Details(int? id)
        {
            var line = railwayLineService.GetIncluding(
                d => d.Id == id,
                d => d.Country)
             .FirstOrDefault();

            if (line == null)
            {
                return NotFound();
            }

            return View(line);
        }

        public override IActionResult Create()
        {
            RailwayLineViewModel model = new RailwayLineViewModel() { };
            SelectList selectListCountries = new SelectList(countries, "Id", "Name"); ;

            model.SelectListCountries = selectListCountries;

            return View("Create", model);
        }

        public override IActionResult Edit(int? id)
        {
            var line = railwayLineService.GetIncluding(
                  d => d.Id == id,
                  d => d.Country)
                .FirstOrDefault();

            if (line == null)
            {
                return NotFound();
            }

            SelectList selectListCountries = new SelectList(countries, "Id", "Name"); ;

            var railwayLineViewModel = new RailwayLineViewModel()
            {
                SelectListCountries = selectListCountries,

                CountryID = line.CountryID,
                Description = line.Description,
                Id = line.Id,
                Name = line.Name,
                Country = line.Country,
                LineType = line.LineType
            };

            return PartialView(railwayLineViewModel);
        }
    }
}
