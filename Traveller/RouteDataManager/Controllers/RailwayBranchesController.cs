﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Domain.Transport.Railway;

namespace RouteDataManager.Controllers
{
    public class RailwayBranchesController : Controller
    {
        private readonly ApplicationContext _context;

        public RailwayBranchesController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(BranchIndexViewModel branchIndexViewModel)
        {
            IOrderedQueryable<RailwayBranch>? applicationContext;

            if (branchIndexViewModel.FilterCountry.CountryID != 0)
            {
                applicationContext = _context.RailwayBranches
                      .Where(
                        b => b.RailwayLine.CountryID == branchIndexViewModel.FilterCountry.CountryID)
                        
                     
                    .Include(d => d.Stations)
                    .OrderBy(d => d.Name);
            }
            else
            {
                applicationContext = _context.RailwayBranches.Include(b => b.Stations).OrderBy(b => b.Name);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", branchIndexViewModel.FilterCountry.CountryID);

            branchIndexViewModel.SelectListCountries = selectListCountries;
            branchIndexViewModel.Branches = await applicationContext.ToListAsync();

            return PartialView(branchIndexViewModel);
        }

        // GET: Branches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RailwayBranches == null)
            {
                return NotFound();
            }

            var branch = await _context.RailwayBranches
                .FirstOrDefaultAsync(m => m.RailwayBranchID == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // GET: Branches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Branches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BranchID,Name,Description,MainBranch")] RailwayBranch branch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branch);
        }

        // GET: Branches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RailwayBranches == null)
            {
                return NotFound();
            }

            var branch = await _context.RailwayBranches.FindAsync(id);
            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }

        // POST: Branches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BranchID,Name,Description,MainBranch")] RailwayBranch branch)
        {
            if (id != branch.RailwayBranchID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchExists(branch.RailwayBranchID))
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
            return View(branch);
        }

        // GET: Branches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RailwayBranches == null)
            {
                return NotFound();
            }

            var branch = await _context.RailwayBranches
                .FirstOrDefaultAsync(m => m.RailwayBranchID == id);
            if (branch == null)
            {
                return NotFound();
            }

            return View(branch);
        }

        // POST: Branches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RailwayBranches == null)
            {
                return Problem("Entity set 'ApplicationContext.Branch'  is null.");
            }
            var branch = await _context.RailwayBranches.FindAsync(id);
            if (branch != null)
            {
                _context.RailwayBranches.Remove(branch);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BranchExists(int id)
        {
          return (_context.RailwayBranches?.Any(e => e.RailwayBranchID == id)).GetValueOrDefault();
        }
    }
}