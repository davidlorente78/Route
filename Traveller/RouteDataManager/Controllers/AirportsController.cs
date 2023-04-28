using Application.Dto;
using Domain.Messages;
using Domain.Transport.Aviation;
using DomainServices.DestinationService;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class AirportsController : GenericController<AirportDto, Airport> , IConsumer<EntityCreated>
    {

        private readonly ICountryService countryService;
        private readonly IAirportService airportService;
        private readonly IAirportTypeService airportTypeService;

        private IEnumerable<CountryDto> countries;
        private IEnumerable<AirportDto> airports;
        private IEnumerable<AirportTypeDto> airportTypes;

        public AirportsController(ApplicationContext context,
            ICountryService countryService,
            IAirportService airportService,
            IAirportTypeService airportTypeService, 
            IPublishEndpoint publishEndpoint) : base(airportService, publishEndpoint)

        {
            this.airportService = airportService;
            this.countryService = countryService;
            this.airportTypeService = airportTypeService;

            countries = countryService.GetAll();
            airports = airportService.GetAll();
            airportTypes = airportTypeService.GetAll();
        }

        [HttpGet]
        public IActionResult Index(AirportIndexViewModel airportIndexViewModel)
        {
            if (airportIndexViewModel is null)
            {
                throw new ArgumentNullException(nameof(airportIndexViewModel));
            }

            var airports = new List<AirportDto>();

            if (airportIndexViewModel.FilterCountry.Id != 0)
            {
                airports = airportService.GetIncluding(
                   d => d.AirportCountryId == airportIndexViewModel.FilterCountry.Id && d.AirportType.Id == airportIndexViewModel.FilterAirportType.Id,
                   d => d.AirportCountry, d => d.AirportType).ToList();
            }
            else
            {
                airports = airportService.GetIncluding(
                    d => d.Id == d.Id, //TODO
                    d => d.AirportCountry, d => d.AirportType).ToList();
            }

            SelectList selectListCountries = new SelectList(countries, "Id", "Name", airportIndexViewModel.FilterCountry.Id);
            SelectList selectListAirportTypes = new SelectList(airportTypes, "Id", "Description", airportIndexViewModel.FilterAirportType.Id);

            airportIndexViewModel.SelectListCountries = selectListCountries;
            airportIndexViewModel.SelectListAirportTypes = selectListAirportTypes;
            airportIndexViewModel.Airports = airports;

            return PartialView(airportIndexViewModel);
        }

        public override IActionResult Details(int? id)
        {
            var airportDto = airportService.GetIncluding(
               d => d.Id == id,
               d => d.AirportType)
            .FirstOrDefault();

            if (airportDto == null)
            {
                return NotFound();
            }

            return PartialView(airportDto);
        }


        public async Task Consume(ConsumeContext<EntityCreated> context)
        {
            throw new NotImplementedException();
        }

    }
}
