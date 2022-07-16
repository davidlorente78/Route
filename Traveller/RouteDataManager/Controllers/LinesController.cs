using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain;
using RouteDataManager.Repositories;

namespace RouteDataManager.Controllers
{
    public class LinesController : Controller
    {
        private readonly ApplicationContext _context;

        public LinesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Lines
        public async Task<IActionResult> Index()
        {
              return _context.Line != null ? 
                          View(await _context.Line.ToListAsync()) :
                          Problem("Entity set 'ApplicationContext.Line'  is null.");
        }

        // GET: Lines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Line == null)
            {
                return NotFound();
            }

            var line = await _context.Line
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
            return View();
        }

        // POST: Lines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LineID,LineType,Name,Description")] Line line)
        {
            if (ModelState.IsValid)
            {
                _context.Add(line);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(line);
        }

        // GET: Lines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Line == null)
            {
                return NotFound();
            }

            var line = await _context.Line.FindAsync(id);
            if (line == null)
            {
                return NotFound();
            }
            return View(line);
        }

        // POST: Lines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LineID,LineType,Name,Description")] Line line)
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
            return View(line);
        }

        // GET: Lines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Line == null)
            {
                return NotFound();
            }

            var line = await _context.Line
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
            if (_context.Line == null)
            {
                return Problem("Entity set 'ApplicationContext.Line'  is null.");
            }
            var line = await _context.Line.FindAsync(id);
            if (line != null)
            {
                _context.Line.Remove(line);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LineExists(int id)
        {
          return (_context.Line?.Any(e => e.LineID == id)).GetValueOrDefault();
        }
    }
}
