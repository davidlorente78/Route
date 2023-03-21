using Domain.Transport.Railway;
using DomainServices.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class RailwayLinesController : Controller
    {
        private readonly ApplicationContext _context;
        private ICountryService ICountryService;

        public RailwayLinesController(ApplicationContext context)
        {
            _context = context;
        }

        //// GET: Lines
        //public async Task<IActionResult> Index()
        //{
        //    var applicationContext = _context.Lines.Include(l => l.Country);
        //    return View(await applicationContext.ToListAsync());
        //}

        public async Task<IActionResult> Index(LineIndexViewModel lineIndexViewModel)
        {
            IOrderedQueryable<RailwayLine>? applicationContext;

            if (lineIndexViewModel.FilterCountry.Id != 0)
            {
                applicationContext = _context.RailwayLines
                    .Where(
                        d => d.CountryID == lineIndexViewModel.FilterCountry.Id

                     )
                    .Include(d => d.Country)
                    .OrderBy(d => d.Name);
            }
            else
            {
                applicationContext = _context.RailwayLines.Include(b => b.Branches).OrderBy(b => b.RailwayLineID);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", lineIndexViewModel.FilterCountry.Id);

            lineIndexViewModel.SelectListCountries = selectListCountries;
            lineIndexViewModel.Lines = await applicationContext.ToListAsync();

            return PartialView(lineIndexViewModel);
        }

        // GET: Lines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RailwayLines == null)
            {
                return NotFound();
            }

            var line = await _context.RailwayLines
                .Include(l => l.Country)
                .FirstOrDefaultAsync(m => m.RailwayLineID == id);
            if (line == null)
            {
                return NotFound();
            }

            return View(line);
        }

        // GET: Lines/Create
        public IActionResult Create()
        {
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name");
            return View();
        }

        // POST: Lines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LineID,Name,Description,LineType,CountryID")] RailwayLine line)
        {
            if (ModelState.IsValid)
            {
                _context.Add(line);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name", line.CountryID);
            return View(line);
        }

        // GET: Lines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RailwayLines == null)
            {
                return NotFound();
            }

            var line = await _context.RailwayLines.FindAsync(id);
            if (line == null)
            {
                return NotFound();
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name", line.CountryID);
            return View(line);
        }

        // POST: Lines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LineID,Name,Description,LineType,CountryID")] RailwayLine line)
        {
            if (id != line.RailwayLineID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(line);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LineExists(line.RailwayLineID))
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
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name", line.CountryID);
            return View(line);
        }

        // GET: Lines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RailwayLines == null)
            {
                return NotFound();
            }

            var line = await _context.RailwayLines
                .Include(l => l.Country)
                .FirstOrDefaultAsync(m => m.RailwayLineID == id);
            if (line == null)
            {
                return NotFound();
            }

            return View(line);
        }

        // POST: Lines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RailwayLines == null)
            {
                return Problem("Entity set 'ApplicationContext.Line'  is null.");
            }
            var line = await _context.RailwayLines.FindAsync(id);
            if (line != null)
            {
                _context.RailwayLines.Remove(line);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LineExists(int id)
        {
            return (_context.RailwayLines?.Any(e => e.RailwayLineID == id)).GetValueOrDefault();
        }
    }
}
