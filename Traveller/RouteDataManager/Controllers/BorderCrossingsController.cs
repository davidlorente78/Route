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

        //// GET: Frontiers
        //public async Task<IActionResult> Index()
        //{
        //    var applicationContext = _context.Frontiers.Include(f => f.Final).Include(f => f.Origin).Include(f => f.FrontierType);
        //    return View(await applicationContext.ToListAsync());
        //}

        public async Task<IActionResult> Index(FrontiersIndexViewModel frontiersIndexViewModel)
        {
            IOrderedQueryable<BorderCrossing>? applicationContext;

            if ((frontiersIndexViewModel.FilterCountryOrigin.CountryID != 0) && (frontiersIndexViewModel.FilterCountryFinal.CountryID != 0))
            {
                applicationContext = _context.BorderCrossings.Where(
                    f => f.Origin.CountryID == frontiersIndexViewModel.FilterCountryOrigin.CountryID
                && f.Final.CountryID == frontiersIndexViewModel.FilterCountryFinal.CountryID
                && f.FrontierType.BorderCrossingTypeID == frontiersIndexViewModel.FilterFrontierType.BorderCrossingTypeID).Include(f => f.Origin).Include(f => f.Final).OrderBy(f => f.Name);
            }
            else
            {
                applicationContext = (IOrderedQueryable<BorderCrossing>?)_context.BorderCrossings.Include(f => f.Final).Include(f => f.Origin);
            }

            SelectList selectListCountriesOrigin = new SelectList(_context.Countries, "CountryID", "Name", frontiersIndexViewModel.FilterCountryOrigin.CountryID);
            SelectList selectListCountriesFinal = new SelectList(_context.Countries, "CountryID", "Name", frontiersIndexViewModel.FilterCountryFinal.CountryID);
            SelectList selectListFrontierTypes = new SelectList(_context.BorderCrossingTypes, "BorderCrossingTypeID", "Description", frontiersIndexViewModel.FilterFrontierType.BorderCrossingTypeID);

            frontiersIndexViewModel.SelectListCountriesOrigin = selectListCountriesOrigin;
            frontiersIndexViewModel.SelectListCountriesFinal = selectListCountriesFinal;
            frontiersIndexViewModel.SelectListFrontierTypes = selectListFrontierTypes;
            frontiersIndexViewModel.Frontiers = await applicationContext.ToListAsync();

            return PartialView(frontiersIndexViewModel);
        }

        // GET: Frontiers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BorderCrossings == null)
            {
                return NotFound();
            }

            var frontier = await _context.BorderCrossings
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .Include(f => f.FrontierType)
                .FirstOrDefaultAsync(m => m.BorderCrossingID == id);

            if (frontier == null)
            {
                return NotFound();
            }

            return View(frontier);
        }

        // GET: Frontiers/Create
        public IActionResult Create()
        {
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name");
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name");
            ViewData["FrontierTypes"] = new SelectList(_context.BorderCrossingTypes, "FrontierTypeID", "Description"); //Selected?

            return View();
        }

        // POST: Frontiers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FrontierID,OriginID,FinalID,Name,Description,FrontierTypeID")] BorderCrossing frontier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frontier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name", frontier.FinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name", frontier.OriginID);
            ViewData["FrontierTypes"] = new SelectList(_context.BorderCrossingTypes, "FrontierTypeID", "Description", frontier.FrontierType.BorderCrossingTypeID);

            return View(frontier);
        }

        // GET: Frontiers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BorderCrossings == null)
            {
                return NotFound();
            }

            var frontier = _context.BorderCrossings
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .Include(f => f.FrontierType)
                .Single(f => f.BorderCrossingID == id);
            if (frontier == null)
            {
                return NotFound();
            }

            //HERE items, data Value, data Text
            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name", frontier.FinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name", frontier.OriginID);
            ViewData["FrontierTypes"] = new SelectList(_context.BorderCrossingTypes, "FrontierTypeID", "Description", frontier.FrontierType.BorderCrossingTypeID);

            return View(frontier);
        }

        // POST: Frontiers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BorderCrossing frontier)
        {
            if (id != frontier.BorderCrossingID)
            {
                return NotFound();
            }

            //TODO ASK
            var FrontierTypeRecovered = _context.BorderCrossingTypes.Single(t => t.BorderCrossingTypeID == frontier.FrontierType.BorderCrossingTypeID);
            frontier.FrontierType = FrontierTypeRecovered;

            //Recover Final and Origin

            var DestinationOriginRecovered = _context.Destinations.Include(f => f.DestinationTypes).Single(d => d.DestinationID == frontier.OriginID);

            frontier.Origin = DestinationOriginRecovered;

            var DestinationFinalRecovered = _context.Destinations.Include(f => f.DestinationTypes).Single(d => d.DestinationID == frontier.FinalID);

            frontier.Final = DestinationFinalRecovered;

            //TODO Model State check 
            //if (ModelState.IsValid)
            //{
            try
            {
                _context.Update(frontier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FrontierExists(frontier.BorderCrossingID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //}

            ViewData["FinalID"] = new SelectList(_context.Destinations, "DestinationID", "Name", frontier.FinalID);
            ViewData["OriginID"] = new SelectList(_context.Destinations, "DestinationID", "Name", frontier.OriginID);
            ViewData["FrontierTypes"] = new SelectList(_context.BorderCrossingTypes, "FrontierTypeID", "Description", frontier.FrontierType.BorderCrossingTypeID);

            return View(frontier);
        }

        // GET: Frontiers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BorderCrossings == null)
            {
                return NotFound();
            }

            var frontier = await _context.BorderCrossings
                .Include(f => f.Final)
                .Include(f => f.Origin)
                .Include(f => f.FrontierType)
                .FirstOrDefaultAsync(m => m.BorderCrossingID == id);
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
            if (_context.BorderCrossings == null)
            {
                return Problem("Entity set 'ApplicationContext.Frontiers'  is null.");
            }
            var frontier = await _context.BorderCrossings.FindAsync(id);
            if (frontier != null)
            {
                _context.BorderCrossings.Remove(frontier);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrontierExists(int id)
        {
            return (_context.BorderCrossings?.Any(e => e.BorderCrossingID == id)).GetValueOrDefault();
        }
    }
}
