using Domain.Messages;
using Domain.Transport.Railway;
using DomainServices.DestinationService;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using RouteDataManager.ViewModels.RailwaySystem;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class RailwayStationsController : GenericController<RailwayStationDto, RailwayStation>, IConsumer<DestinationCreated>
    {
        private readonly ApplicationContext _context;
        private ICountryService countryService;
        private IDestinationService destinationService;

        private IRailwayLineService railwayLineService;
        private IRailwayStationService railwayStationService;
        private IEnumerable<CountryDto> countries;

        public RailwayStationsController(
          ICountryService countryService,
          IRailwayLineService railwayLineService,
          IDestinationService destinationService,
          IPublishEndpoint publishEndpoint,
          IRailwayStationService railwayStationService) : base(railwayStationService, publishEndpoint)
        {
            this.countryService = countryService;
            this.destinationService = destinationService;
            this.railwayLineService = railwayLineService;
            this.railwayStationService = railwayStationService;

            countries = countryService.GetAll();
        }

        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> Index(StationIndexViewModel stationIndexViewModel)
        {
            var stations = railwayStationService.GetIncluding(
                 s => s.Destinations.Select(d => d.CountryId).Contains(stationIndexViewModel.FilterCountry.Id),
               d => d.Destinations);

            var lines = railwayLineService.GetIncluding(
                l => l.CountryID == stationIndexViewModel.FilterCountry.Id,
                l => l.Branches);

            stationIndexViewModel.FilterLine = lines.FirstOrDefault();


            SelectList selectListCountries = new SelectList(countries, "Id", "Name", stationIndexViewModel.FilterCountry.Id);
            SelectList selectListLines = new SelectList(lines, "Id", "Name", stationIndexViewModel.FilterLine.Id);

            stationIndexViewModel.SelectListCountries = selectListCountries;
            stationIndexViewModel.SelectListLines = selectListLines;
            stationIndexViewModel.Stations = stations;

            return PartialView(stationIndexViewModel);
        }

        public JsonResult GetLinesListByCountryID(int CountryID)
        {
            //https://www.findandsolve.com/articles/cascading-dropdownlist-in-net-core-5
            //https://www.rafaelacosta.net/Blog/2019/11/24/c%C3%B3mo-crear-un-cascading-dropdownlist-en-aspnet-mvc

            var lines = railwayLineService.GetIncluding(l => l.CountryID == CountryID, l => l.Country);

            var selectListLines = new SelectList(lines, "Id", "Name");

            return Json(selectListLines);
        }

        public override IActionResult Create()
        {
            var model = new RailwayStationViewModel() { };

            var lines = railwayLineService.GetIncluding(l => l.CountryID == countries.First().Id, l => l.Country);

            model.SelectListLines = new SelectList(lines, "Id", "Name");
            model.SelectListCountries = new SelectList(countries, "Id", "Name"); ;

            return View("Create", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LocalName,Type,Remarks")] RailwayStation station)
        {
            if (ModelState.IsValid)
            {
                _context.Add(station);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(station);
        }

        public override IActionResult Edit(int? id)
        {
            var station = railwayStationService.GetIncluding(
                  d => d.Id == id,
                  d => d.Destinations)
                .FirstOrDefault();

            if (station == null)
            {
                return NotFound();
            }

            SelectList selectListCountries = new SelectList(countries, "Id", "Name"); ;

            var railwayStationViewModel = new RailwayStationViewModel()
            {
                SelectListCountries = selectListCountries,

                Remarks = station.Remarks,
                Id = station.Id,
                Name = station.Name,
                LocalName = station.LocalName,
                Type = station.Type
            };

            return PartialView(railwayStationViewModel);
        }

        public Task Consume(ConsumeContext<DestinationCreated> context)
        {
            //TODO
            //Create Station from Destination Created Message
            //Check DestinationTypeId

            var destinationId = context.Message.Id; //ID station is needed here

            var station = new RailwayStationDto()
            {
                Name = context.Message.Name,
                Remarks = context.Message.Message,
            };

            //Repo Destination
            var destination = destinationService.GetById(destinationId);

            station.Destinations.Add(destination);

            railwayStationService.Add(station);
            return _context.SaveChangesAsync();

        }
    }
}
