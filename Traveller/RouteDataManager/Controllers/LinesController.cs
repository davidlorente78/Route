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
    public class LinesController : Controller
    {
        private readonly ApplicationContext _context;

        public LinesController(ApplicationContext context)
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
            IOrderedQueryable<Line>? applicationContext;

            if (lineIndexViewModel.FilterCountry.CountryID != 0)
            {
                applicationContext = _context.Lines
                    .Where(
                        d => d.CountryID == lineIndexViewModel.FilterCountry.CountryID
                     
                     )
                    .Include(d => d.Country)
                    .OrderBy(d => d.Name);
            }
            else
            {
                applicationContext = _context.Lines.Include(b => b.Branches).OrderBy(b => b.LineID);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", lineIndexViewModel.FilterCountry.CountryID);

            lineIndexViewModel.SelectListCountries = selectListCountries;
            lineIndexViewModel.Lines = await applicationContext.ToListAsync();

            return PartialView(lineIndexViewModel);
        }

        // GET: Lines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lines == null)
            {
                return NotFound();
            }

            var line = await _context.Lines
                .Include(l => l.Country)
                .FirstOrDefaultAsync(m => m.LineID == id);
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
        public async Task<IActionResult> Create([Bind("LineID,Name,Description,LineType,CountryID")] Line line)
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
            if (id == null || _context.Lines == null)
            {
                return NotFound();
            }

            var line = await _context.Lines.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("LineID,Name,Description,LineType,CountryID")] Line line)
        {
            if (id != line.LineID)
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
                    if (!LineExists(line.LineID))
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
            if (id == null || _context.Lines == null)
            {
                return NotFound();
            }

            var line = await _context.Lines
                .Include(l => l.Country)
                .FirstOrDefaultAsync(m => m.LineID == id);
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
            if (_context.Lines == null)
            {
                return Problem("Entity set 'ApplicationContext.Line'  is null.");
            }
            var line = await _context.Lines.FindAsync(id);
            if (line != null)
            {
                _context.Lines.Remove(line);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LineExists(int id)
        {
          return (_context.Lines?.Any(e => e.LineID == id)).GetValueOrDefault();
        }
    }
}
