using Application.Dto;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.ViewModels;
using Traveller.Application.Dto;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class VisasController : GenericController<VisaDto, Visa>
    {
        private readonly ICountryService countryService;
        private readonly IVisaService visaService;
        private readonly INationalityService nationalityService;

        private IEnumerable<CountryDto> countries;
        private IEnumerable<NationalityDto> nationalities;

        public VisasController(
              ICountryService countryService,
              IVisaService visaService,
              INationalityService nationalityService,
              IPublishEndpoint publishEndPoint) : base(visaService, publishEndPoint)

        {
            this.countryService = countryService;
            this.visaService = visaService;
            this.nationalityService = nationalityService;

            countries = countryService.GetAll();
            nationalities = nationalityService.GetAll();
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Index(VisaIndexViewModel visaIndexViewModel)
        {
            if (visaIndexViewModel.FilterCountry.Id != 0)
            {
                var nationalityDto = nationalityService.GetById(visaIndexViewModel.FilterNationality.Id);
                var countryDto = countryService.GetById(visaIndexViewModel.FilterCountry.Id);

                var visas = visaService.GetIncluding(d => d.CountryId == countryDto.Id, v => v.QualifyNationalities);

                var visasWhereNationalityApply = visas.Where(v => v.QualifyNationalities.Any(qn => qn.Id == nationalityDto.Id));

                visaIndexViewModel.FilterCountry = countryDto;
                visaIndexViewModel.FilterNationality = nationalityDto;

                visaIndexViewModel.Visas = visasWhereNationalityApply
                  .OrderBy(v => v.Name)
                  .ToList();
            }
            else
            {
                var visas = visaService.GetIncluding(d => d.Id == d.Id, v => v.QualifyNationalities);
            }

            SelectList selectListCountries = new SelectList(countries, "Id", "Name", visaIndexViewModel.FilterCountry.Id);
            SelectList selectListNationalities = new SelectList(nationalities, "Id", "Description", visaIndexViewModel.FilterNationality.Id);

            visaIndexViewModel.SelectListCountries = selectListCountries;
            visaIndexViewModel.SelectListNationalities = selectListNationalities;

            return PartialView(visaIndexViewModel);
        }

        //Si se tiene que incluir un agregado o algun campo con Include no es posible utilizar el servicio Generico TODO
        public override IActionResult Edit(int? id)
        {
            if (id == null || visaService.Exists(id.Value) == false)
            {
                return NotFound();
            }

            VisaDto visaDto = visaService.GetIncluding(v => v.Id == id, v => v.QualifyNationalities).FirstOrDefault();

            if (visaDto == null)
            {
                return NotFound();
            }

            return PartialView(visaDto);
        }
    }
}
