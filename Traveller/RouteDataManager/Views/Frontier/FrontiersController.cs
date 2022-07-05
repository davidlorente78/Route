using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Views.Frontier
{
    public class FrontiersController : Controller
    {
        private readonly ApplicationContext _context;

        public FrontiersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Frontiers
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.Frontiers.Include(f => f.Final).Include(f => f.Origin);
            return View(await applicationContext.ToListAsync());
        }

        // GET: Frontiers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Frontiers == null)
            {
                return NotFound();
            }

            var frontier = await _context.Frontiers
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .FirstOrDefaultAsync(m => m.FrontierID == id);
            if (frontier == null)
            {
                return NotFound();
            }

            return View(frontier);
        }

        // GET: Frontiers/Create
        public IActionResult Create()
        {
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID");
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID");
            return View();
        }

        // POST: Frontiers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FrontierID,OriginID,FinalID,Name,Description,Type")] Traveller.Domain.Frontier frontier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frontier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID", frontier.FinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID", frontier.OriginID);
            return View(frontier);
        }

        // GET: Frontiers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Frontiers == null)
            {
                return NotFound();
            }

            var frontier = await _context.Frontiers.FindAsync(id);
            if (frontier == null)
            {
                return NotFound();
            }
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID", frontier.FinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID", frontier.OriginID);
            return View(frontier);
        }

        // POST: Frontiers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FrontierID,OriginID,FinalID,Name,Description,Type")] Traveller.Domain.Frontier frontier)
        {
            if (id != frontier.FrontierID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frontier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrontierExists(frontier.FrontierID))
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
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID", frontier.FinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "DestinationID", frontier.OriginID);
            return View(frontier);
        }

        // GET: Frontiers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Frontiers == null)
            {
                return NotFound();
            }

            var frontier = await _context.Frontiers
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .FirstOrDefaultAsync(m => m.FrontierID == id);
            if (frontier == null)
            {
                return NotFound();
            }

            return View(frontier);
        }

        // POST: Frontiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Frontiers == null)
            {
                return Problem("Entity set 'ApplicationContext.Frontiers'  is null.");
            }
            var frontier = await _context.Frontiers.FindAsync(id);
            if (frontier != null)
            {
                _context.Frontiers.Remove(frontier);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrontierExists(int id)
        {
          return (_context.Frontiers?.Any(e => e.FrontierID == id)).GetValueOrDefault();
        }
    }
}
