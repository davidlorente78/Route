using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Controllers
{
    public class VisasController : Controller
    {
        private readonly ApplicationContext _context;

        public VisasController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Visas
        public async Task<IActionResult> Index()
        {
              return _context.Visa != null ? 
                          View(await _context.Visa.ToListAsync()) :
                          Problem("Entity set 'ApplicationContext.Visa'  is null.");
        }

        // GET: Visas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Visa == null)
            {
                return NotFound();
            }

            var visa = await _context.Visa
                .FirstOrDefaultAsync(m => m.VisaID == id);
            if (visa == null)
            {
                return NotFound();
            }

            return View(visa);
        }

        // GET: Visas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisaID,Name,CountryCode,Description,OnLine,OnArrival,URL,Duration,Entries,Category,Validity,Extensible,ExtensionDays,CurrencyFee,ExtensionFee,AdditionalDaysFee,Currency,Fee,QualifyNationalities")] Visa visa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visa);
        }

        // GET: Visas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Visa == null)
            {
                return NotFound();
            }

            var visa = await _context.Visa.FindAsync(id);
            if (visa == null)
            {
                return NotFound();
            }
            return View(visa);
        }

        // POST: Visas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisaID,Name,CountryCode,Description,OnLine,OnArrival,URL,Duration,Entries,Category,Validity,Extensible,ExtensionDays,CurrencyFee,ExtensionFee,AdditionalDaysFee,Currency,Fee,QualifyNationalities")] Visa visa)
        {
            if (id != visa.VisaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisaExists(visa.VisaID))
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
            return View(visa);
        }

        // GET: Visas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Visa == null)
            {
                return NotFound();
            }

            var visa = await _context.Visa
                .FirstOrDefaultAsync(m => m.VisaID == id);
            if (visa == null)
            {
                return NotFound();
            }

            return View(visa);
        }

        // POST: Visas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Visa == null)
            {
                return Problem("Entity set 'ApplicationContext.Visa'  is null.");
            }
            var visa = await _context.Visa.FindAsync(id);
            if (visa != null)
            {
                _context.Visa.Remove(visa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisaExists(int id)
        {
          return (_context.Visa?.Any(e => e.VisaID == id)).GetValueOrDefault();
        }
    }
}
