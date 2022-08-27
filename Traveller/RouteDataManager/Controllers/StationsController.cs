using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;

namespace RouteDataManager.Controllers
{
    public class StationsController : Controller
    {
        private readonly ApplicationContext _context;

        public StationsController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(StationIndexViewModel stationIndexViewModel)
        {
            IOrderedQueryable<Station>? applicationContext;
            IQueryable<Line>? itemsSelectLines = _context.Lines;

            if (stationIndexViewModel.FilterCountry.CountryID != 0)
            {
                itemsSelectLines = _context.Lines.Where(l => l.CountryID == stationIndexViewModel.FilterCountry.CountryID);
                stationIndexViewModel.FilterLine = itemsSelectLines.FirstOrDefault();
                applicationContext = _context.Stations
                    .Where(
                        s => s.Destinations.Select(d => d.CountryID).Contains(stationIndexViewModel.FilterCountry.CountryID)
                     )
                    .Include(s => s.Destinations)
                    .OrderBy(s => s.StationID);
            }
            else
            {
                applicationContext = _context.Stations.Include(s => s.Destinations).OrderBy(s => s.Name);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", stationIndexViewModel.FilterCountry.CountryID);
            SelectList selectListLines = new SelectList(itemsSelectLines.ToList(), "LineID", "Name", stationIndexViewModel.FilterLine.LineID);

            stationIndexViewModel.SelectListCountries = selectListCountries;
            stationIndexViewModel.SelectListLines = selectListLines;
            stationIndexViewModel.Stations = await applicationContext.ToListAsync();

            return PartialView(stationIndexViewModel);
        }



        public JsonResult GetLinesListByCountryID(int CountryID)
        {
            //https://www.findandsolve.com/articles/cascading-dropdownlist-in-net-core-5
            //https://www.rafaelacosta.net/Blog/2019/11/24/c%C3%B3mo-crear-un-cascading-dropdownlist-en-aspnet-mvc

            List<Line>? data = _context.Lines.Where(l => l.CountryID == CountryID).ToList();

            var selectList = new SelectList(data, "LineID", "Name");
            return Json(selectList);
        }

        // GET: Stations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Stations == null)
            {
                return NotFound();
            }

            var station = await _context.Stations
                .FirstOrDefaultAsync(m => m.StationID == id);
            if (station == null)
            {
                return NotFound();
            }

            return View(station);
        }

        // GET: Stations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StationID,Name,LocalName,Type,Remarks")] Station station)
        {
            if (ModelState.IsValid)
            {
                _context.Add(station);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(station);
        }

        // GET: Stations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Stations == null)
            {
                return NotFound();
            }

            var station = await _context.Stations.FindAsync(id);
            if (station == null)
            {
                return NotFound();
            }
            return View(station);
        }

        // POST: Stations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StationID,Name,LocalName,Type,Remarks")] Station station)
        {
            if (id != station.StationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(station);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StationExists(station.StationID))
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
            return View(station);
        }

        // GET: Stations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Stations == null)
            {
                return NotFound();
            }

            var station = await _context.Stations
                .FirstOrDefaultAsync(m => m.StationID == id);
            if (station == null)
            {
                return NotFound();
            }

            return View(station);
        }

        // POST: Stations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Stations == null)
            {
                return Problem("Entity set 'ApplicationContext.Station'  is null.");
            }
            var station = await _context.Stations.FindAsync(id);
            if (station != null)
            {
                _context.Stations.Remove(station);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StationExists(int id)
        {
            return (_context.Stations?.Any(e => e.StationID == id)).GetValueOrDefault();
        }
    }
}
