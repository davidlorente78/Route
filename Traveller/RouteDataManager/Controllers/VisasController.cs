using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
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

     
        public async Task<IActionResult> Index(VisaIndexViewModel visaIndexViewModel)
        {
            IOrderedQueryable<Visa>? applicationContext;
            IQueryable<Nationality>? itemsSelectNationalities = _context.Nationalities;

            if (visaIndexViewModel.FilterCountry.CountryID != 0)
            {


                var checkNationalities = _context.Visas
                    .Where(
                        v => v.QualifyNationalities.Select(d => d.NationalityID).Contains(visaIndexViewModel.FilterNationality.NationalityID)).ToList();

                var checkCountry = _context.Visas
                    .Where(
                        v => v.BorderCrossings.Select(d => d.BorderCrossingCountryID).Contains(visaIndexViewModel.FilterCountry.CountryID)).ToList();

                var checkJoin = checkNationalities.Intersect(checkCountry);

                itemsSelectNationalities = _context.Nationalities;
                visaIndexViewModel.FilterNationality = itemsSelectNationalities.FirstOrDefault();

                visaIndexViewModel.Visas = checkJoin
                  .OrderBy(v => v.Name).ToList();             
            }
            else
            {
                applicationContext = _context.Visas.Include(v => v.QualifyNationalities).OrderBy(s => s.Name);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", visaIndexViewModel.FilterCountry.CountryID);
            SelectList selectListNationalities = new SelectList(itemsSelectNationalities.ToList(), "NationalityID", "Description", visaIndexViewModel.FilterNationality.NationalityID);

            visaIndexViewModel.SelectListCountries = selectListCountries;
            visaIndexViewModel.SelectListNationalities = selectListNationalities;
          

            return PartialView(visaIndexViewModel);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Visas == null)
            {
                return NotFound();
            }

            var visa = await _context.Visas
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
            if (id == null || _context.Visas == null)
            {
                return NotFound();
            }

            var visa = await _context.Visas.FindAsync(id);
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
            if (id == null || _context.Visas == null)
            {
                return NotFound();
            }

            var visa = await _context.Visas
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
            if (_context.Visas == null)
            {
                return Problem("Entity set 'ApplicationContext.Visa'  is null.");
            }
            var visa = await _context.Visas.FindAsync(id);
            if (visa != null)
            {
                _context.Visas.Remove(visa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisaExists(int id)
        {
          return (_context.Visas?.Any(e => e.VisaID == id)).GetValueOrDefault();
        }
    }
}
