using Application.Dto;
using Domain.Transport.Aviation;
using DomainServices.DestinationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Controllers.Generic;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Traveller.Application.Dto;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class AirportsController : GenericController<AirportDto, Airport>
    {
        private readonly ApplicationContext _context;

        private readonly ICountryService countryService;
        private readonly IAirportService airportService;
        private readonly IAirportTypeService airportTypeService;

        private IEnumerable<CountryDto> countries;
        private IEnumerable<AirportDto> airports;
        private IEnumerable<AirportTypeDto> airportTypes;

        public AirportsController(ApplicationContext context,
            ICountryService countryService,
            IAirportService airportService,
            IAirportTypeService airportTypeService
            )
            : base(airportService)
        {
            this.airportService = airportService;
            this.countryService = countryService;
            this.airportTypeService = airportTypeService;

            countries = countryService.GetAll();
            airports = airportService.GetAll();
            airportTypes = airportTypeService.GetAll();

            _context = context;
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
                   d => d.AirportCountryID == airportIndexViewModel.FilterCountry.Id && d.AirportType.Id == airportIndexViewModel.FilterAirportType.Id,
                   d => d.AirportCountry, d => d.AirportType).ToList();
            }
            else
            {
                airports = airportService.GetIncluding(
                    d => d.Id == d.Id, //tODO
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
            var destination = airportService.GetIncluding(
               d => d.Id == id,
               d => d.AirportType)
            .FirstOrDefault();

            if (destination == null)
            {
                return NotFound();
            }

            return PartialView(destination);
        }

        //// GET: Airports/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Airports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AirportID,IATACode,ICAOCode,Name,LocalName")] Airport airport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airport);
        }

        //// GET: Airports/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Airports == null)
        //    {
        //        return NotFound();
        //    }

        //    var airport = await _context.Airports.FindAsync(id);
        //    if (airport == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(airport);
        //}

        // POST: Airports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AirportID,IATACode,ICAOCode,Name,LocalName")] Airport airport)
        {
            if (id != airport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!airportService.Exists(airport.Id))
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
            return View(airport);
        }

        //// GET: Airports/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Airports == null)
        //    {
        //        return NotFound();
        //    }

        //    var airport = await _context.Airports
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (airport == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(airport);
        //}

        //// POST: Airports/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Airports == null)
        //    {
        //        return Problem("Entity set 'ApplicationContext.Airport'  is null.");
        //    }
        //    var airport = await _context.Airports.FindAsync(id);
        //    if (airport != null)
        //    {
        //        _context.Airports.Remove(airport);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AirportExists(int id)
        //{
        //    return (_context.Airports?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
