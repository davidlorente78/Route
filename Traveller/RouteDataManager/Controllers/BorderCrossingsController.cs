using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Traveller.Domain;

namespace RouteDataManager.Controllers
{
    public class BorderCrossingsController : Controller
    {
        private readonly ApplicationContext _context;

        public BorderCrossingsController(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(BorderCrossingsIndexViewModel borderCrossingsIndexViewModel)
        {
            IOrderedQueryable<BorderCrossing>? applicationContext;

            if ((borderCrossingsIndexViewModel.FilterCountryOrigin.Id != 0) && (borderCrossingsIndexViewModel.FilterCountryFinal.Id != 0))
            {
                applicationContext = _context.BorderCrossings.Where(
                    f => f.DestinationOrigin.DestinationCountryID == borderCrossingsIndexViewModel.FilterCountryOrigin.Id
                && f.DestinationFinal.DestinationCountryID == borderCrossingsIndexViewModel.FilterCountryFinal.Id
                && f.BorderCrossingType.BorderCrossingTypeID == borderCrossingsIndexViewModel.FilterBorderCrossingType.BorderCrossingTypeID).Include(f => f.DestinationOrigin).Include(f => f.DestinationFinal).OrderBy(f => f.Name);
            }
            else
            {
                applicationContext = (IOrderedQueryable<BorderCrossing>?)_context.BorderCrossings.Include(f => f.DestinationFinal).Include(f => f.DestinationOrigin);
            }

            SelectList selectListCountriesOrigin = new SelectList(_context.Countries, "Id", "Name", borderCrossingsIndexViewModel.FilterCountryOrigin.Id);
            SelectList selectListCountriesFinal = new SelectList(_context.Countries, "Id", "Name", borderCrossingsIndexViewModel.FilterCountryFinal.Id);
            SelectList selectListBorderCrossingTypes = new SelectList(_context.BorderCrossingTypes, "BorderCrossingTypeID", "Description", borderCrossingsIndexViewModel.FilterBorderCrossingType.BorderCrossingTypeID);

            borderCrossingsIndexViewModel.SelectListCountriesOrigin = selectListCountriesOrigin;
            borderCrossingsIndexViewModel.SelectListCountriesFinal = selectListCountriesFinal;
            borderCrossingsIndexViewModel.SelectListBorderCrossingTypes = selectListBorderCrossingTypes;
            borderCrossingsIndexViewModel.BorderCrossings = await applicationContext.ToListAsync();

            return PartialView(borderCrossingsIndexViewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BorderCrossings == null)
            {
                return NotFound();
            }

            var borderCrossing = await _context.BorderCrossings
                .Include(f => f.DestinationFinal)
                .Include(f => f.DestinationOrigin)
                .Include(f => f.BorderCrossingType)
                .FirstOrDefaultAsync(m => m.BorderCrossingID == id);

            if (borderCrossing == null)
            {
                return NotFound();
            }

            return View(borderCrossing);
        }

        public IActionResult Create()
        {
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name");
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name");
            ViewData["BorderCrossingTypes"] = new SelectList(_context.BorderCrossingTypes, "BorderCrossingTypeID", "Description"); //Selected?

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BorderCrossingID,OriginID,FinalID,Name,Description,BorderCrossingTypeID")] BorderCrossing borderCrossing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borderCrossing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name", borderCrossing.DestinationFinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name", borderCrossing.DestinationOriginID);
            ViewData["BorderCrossingTypes"] = new SelectList(_context.BorderCrossingTypes, "BorderCrossingTypeID", "Description", borderCrossing.BorderCrossingType.BorderCrossingTypeID);

            return View(borderCrossing);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BorderCrossings == null)
            {
                return NotFound();
            }

            var borderCrossing = _context.BorderCrossings
                .Include(f => f.DestinationFinal)
                .Include(f => f.DestinationOrigin)
                .Include(f => f.BorderCrossingType)
                .Single(f => f.BorderCrossingID == id);

            if (borderCrossing == null)
            {
                return NotFound();
            }

            //HERE items, data Value, data Text
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name", borderCrossing.DestinationFinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name", borderCrossing.DestinationOriginID);
            ViewData["BorderCrossingTypes"] = new SelectList(_context.BorderCrossingTypes, "BorderCrossingTypeID", "Description", borderCrossing.BorderCrossingType.BorderCrossingTypeID);

            return View(borderCrossing);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BorderCrossing borderCrossing)
        {
            if (id != borderCrossing.BorderCrossingID)
            {
                return NotFound();
            }

            //TODO ASK
            var BorderCrossingTypeRecovered = _context
                .BorderCrossingTypes
                .Single(t => t.BorderCrossingTypeID == borderCrossing.BorderCrossingType.BorderCrossingTypeID);
            
            borderCrossing.BorderCrossingType = BorderCrossingTypeRecovered;

            //Recover Final and Origin

            var DestinationOriginRecovered = _context.Destinations
                .Include(f => f.DestinationTypes)
                .Single(d => d.DestinationID == borderCrossing.DestinationOriginID);

            borderCrossing.DestinationOrigin = DestinationOriginRecovered;

            var DestinationFinalRecovered = _context.Destinations
                .Include(f => f.DestinationTypes)
                .Single(d => d.DestinationID == borderCrossing.DestinationFinalID);

            borderCrossing.DestinationFinal = DestinationFinalRecovered;

            //TODO Model State check 
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Update(borderCrossing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BorderCrossingExists(borderCrossing.BorderCrossingID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //}

            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name", borderCrossing.DestinationFinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name", borderCrossing.DestinationOriginID);
            ViewData["BorderCrossingTypes"] = new SelectList(_context.BorderCrossingTypes, "BorderCrossingTypeID", "Description", borderCrossing.BorderCrossingType.BorderCrossingTypeID);

            return View(borderCrossing);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BorderCrossings == null)
            {
                return NotFound();
            }

            var borderCrossing = await _context.BorderCrossings
                .Include(f => f.DestinationFinal)
                .Include(f => f.DestinationOrigin)
                .Include(f => f.BorderCrossingType)
                .FirstOrDefaultAsync(m => m.BorderCrossingID == id);

            if (borderCrossing == null)
            {
                return NotFound();
            }

            return View(borderCrossing);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BorderCrossings == null)
            {
                return Problem("Entity set 'ApplicationContext.BorderCrossings'  is null.");
            }

            var borderCrossing = await _context.BorderCrossings.FindAsync(id);
            if (borderCrossing != null)
            {
                _context.BorderCrossings.Remove(borderCrossing);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorderCrossingExists(int id)
        {
            return (_context.BorderCrossings?.Any(e => e.BorderCrossingID == id)).GetValueOrDefault();
        }
    }
}
