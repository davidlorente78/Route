using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Transport.Aviation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;

namespace RouteDataManager.Controllers
{
    public class AirportsController : Controller
    {
        private readonly ApplicationContext _context;

        public AirportsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Airports
        public async Task<IActionResult> Index(AirportIndexViewModel airportIndexViewModel)
        {
            IOrderedQueryable<Airport>? applicationContext;

            if (airportIndexViewModel.FilterCountry.Id != 0)
            {
                //applicationContext = _context.Airports.Where(d => d.CountryID == airportIndexViewModel.FilterCountry.CountryID).Include(d => d.Country).Include(d => d.AirportType).OrderBy(c => c.Country.Name);

                applicationContext = _context.Airports.Where(d => d.AirportCountryID == airportIndexViewModel.FilterCountry.Id && d.AirportType.AirportTypeID == airportIndexViewModel.FilterAirportType.AirportTypeID).Include(d => d.AirportCountry).Include(d => d.AirportType).OrderBy(c => c.AirportCountry.Name);
            }
            else
            {
                applicationContext = _context.Airports.Include(d => d.AirportCountry).Include(d => d.AirportType).OrderBy(c => c.AirportCountry.Name);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", airportIndexViewModel.FilterCountry.Id);
            SelectList selectListAirportTypes = new SelectList(_context.AirportTypes, "AirportTypeID", "Description", airportIndexViewModel.FilterAirportType.AirportTypeID);

            airportIndexViewModel.SelectListCountries = selectListCountries;
            airportIndexViewModel.SelectListAirportTypes = selectListAirportTypes;
            airportIndexViewModel.Airports = await applicationContext.ToListAsync();

            return PartialView(airportIndexViewModel);
        }

            // GET: Airports/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Airports == null)
            {
                return NotFound();
            }

            var airport = await _context.Airports
                .FirstOrDefaultAsync(m => m.AirportID == id);
            if (airport == null)
            {
                return NotFound();
            }

            return View(airport);
        }

        // GET: Airports/Create
        public IActionResult Create()
        {
            return View();
        }

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

        // GET: Airports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Airports == null)
            {
                return NotFound();
            }

            var airport = await _context.Airports.FindAsync(id);
            if (airport == null)
            {
                return NotFound();
            }
            return View(airport);
        }

        // POST: Airports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AirportID,IATACode,ICAOCode,Name,LocalName")] Airport airport)
        {
            if (id != airport.AirportID)
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
                    if (!AirportExists(airport.AirportID))
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

        // GET: Airports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Airports == null)
            {
                return NotFound();
            }

            var airport = await _context.Airports
                .FirstOrDefaultAsync(m => m.AirportID == id);
            if (airport == null)
            {
                return NotFound();
            }

            return View(airport);
        }

        // POST: Airports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Airports == null)
            {
                return Problem("Entity set 'ApplicationContext.Airport'  is null.");
            }
            var airport = await _context.Airports.FindAsync(id);
            if (airport != null)
            {
                _context.Airports.Remove(airport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirportExists(int id)
        {
          return (_context.Airports?.Any(e => e.AirportID == id)).GetValueOrDefault();
        }
    }
}
