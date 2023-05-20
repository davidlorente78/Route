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
    public class RailwayBranchesController : GenericController<RailwayBranchDto, RailwayBranch>
    {
        private ICountryService countryService;
        private IRailwayBranchService railwayBranchService;
        private IEnumerable<CountryDto> countries;

        public RailwayBranchesController(
            ICountryService countryService,
            IRailwayBranchService railwayBranchService,
            IPublishEndpoint publishEndpoint) : base(railwayBranchService, publishEndpoint)
        {
            this.countryService = countryService;
            this.railwayBranchService = railwayBranchService;

            countries = countryService.GetAll();
        }

        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> Index(BranchIndexViewModel branchIndexViewModel)
        {

            var branches = railwayBranchService.GetIncluding(
                b => b.RailwayLine.CountryID == branchIndexViewModel.FilterCountry.Id,
                d => d.Stations);

            SelectList selectListCountries = new SelectList(countries, "Id", "Name", branchIndexViewModel.FilterCountry.Id);

            branchIndexViewModel.SelectListCountries = selectListCountries;
            branchIndexViewModel.Branches = branches;

            return PartialView(branchIndexViewModel);
        }

        public override IActionResult Details(int? id)
        {
            var branch = railwayBranchService.GetIncluding(
                 b => b.Id == id,
                 b => b.Stations)
               .FirstOrDefault();

            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        public override IActionResult Create()
        {
            BranchIndexViewModel model = new BranchIndexViewModel() { };
            SelectList selectListCountries = new SelectList(countries, "Id", "Name"); ;

            model.SelectListCountries = selectListCountries;

            return View("Create", model);
        }

        public override IActionResult Edit(int? id)
        {
            var branch = railwayBranchService.GetIncluding(
                  b => b.Id == id,
                  b => b.Stations)
                .FirstOrDefault();

            if (branch == null)
            {
                return NotFound();
            }

            SelectList selectListCountries = new SelectList(countries, "Id", "Name"); ;

            var railwayBranchViewModel = new RailwayBranchViewModel()
            {
                SelectListCountries = selectListCountries,

                RailwayLineID = branch.RailwayLineID,
                Description = branch.Description,
                Id = branch.Id,
                Name = branch.Name,
                MainBranch = branch.MainBranch,
                Stations = branch.Stations
            };

            return PartialView(railwayBranchViewModel);
        }
    }
}
