﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using RouteDataManager.Repositories;

namespace RouteDataManager.Controllers
{
    public class StationsController : Controller
    {
        private readonly ApplicationContext _context;

        public StationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Stations
        public async Task<IActionResult> Index()
        {
              return _context.Station != null ? 
                          View(await _context.Station.ToListAsync()) :
                          Problem("Entity set 'ApplicationContext.Station'  is null.");
        }

        // GET: Stations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Station == null)
            {
                return NotFound();
            }

            var station = await _context.Station
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
        public async Task<IActionResult> Create([Bind("StationID,Name,Type,Remarks")] Station station)
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
            if (id == null || _context.Station == null)
            {
                return NotFound();
            }

            var station = await _context.Station.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("StationID,Name,Type,Remarks")] Station station)
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
            if (id == null || _context.Station == null)
            {
                return NotFound();
            }

            var station = await _context.Station
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
            if (_context.Station == null)
            {
                return Problem("Entity set 'ApplicationContext.Station'  is null.");
            }
            var station = await _context.Station.FindAsync(id);
            if (station != null)
            {
                _context.Station.Remove(station);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StationExists(int id)
        {
          return (_context.Station?.Any(e => e.StationID == id)).GetValueOrDefault();
        }
    }
}