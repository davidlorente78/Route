using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using Traveller.Domain;

namespace RouteDataManager.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly ApplicationContext _context;

        public DestinationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Destinations
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.Destinations.Include(d => d.Country).Include(d => d.DestinationType).OrderBy(c => c.Country.Name);
            return PartialView(await applicationContext.ToListAsync());
        }

        // GET: Destinations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Destinations == null)
            {
                return NotFound();
            }

            var destination = await _context.Destinations
                .Include(d => d.Country).Include(d => d.DestinationType)
                .FirstOrDefaultAsync(m => m.DestinationID == id);
            if (destination == null)
            {
                return NotFound();
            }

            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name", destination.CountryID);
            ViewData["Type"] = new SelectList(_context.DestinationTypes, "DestinationTypeID", "Description", destination.DestinationType.DestinationTypeID); //NEW

            return PartialView(destination);
        }

        // GET: Destinations/Create
        public IActionResult Create()
        {
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name");
            return PartialView();
        }

        // POST: Destinations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DestinationID,CountryCode,Name,Description,Type,CountryID")] Destination destination)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destination);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name", destination.CountryID);
            ViewData["Type"] = new SelectList(_context.DestinationTypes, "DestinationTypeID", "Description", destination.DestinationType.DestinationTypeID); //NEW

            return PartialView(destination);
        }

        // GET: Destinations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Destinations == null)
            {
                return NotFound();
            }

            var destination = await _context.Destinations.Include(d=>d.Country).Include(d => d.DestinationType).FirstAsync(d=>d.DestinationID==id);
            if (destination == null)
            {
                return NotFound();
            }
            //HERE

            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name", destination.CountryID);
            ViewData["DestinationTypes"] = new SelectList(_context.DestinationTypes, "DestinationTypeID", "Description", destination.DestinationType.DestinationTypeID); //NEW
            return PartialView(destination);
        }

        // POST: Destinations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Destination destination)
        {
            if (id != destination.DestinationID)
            {
                return NotFound();
            }


            var DestinationTypeRecovered = _context.DestinationTypes.Single(t => t.DestinationTypeID == destination.DestinationType.DestinationTypeID);

            destination.DestinationType = DestinationTypeRecovered;
            try
            {

                _context.Update(destination);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinationExists(destination.DestinationID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
            //}
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "Name", destination.CountryID);
            ViewData["DestinationTypes"] = new SelectList(_context.DestinationTypes, "DestinationTypeID", "Description", destination.DestinationType.DestinationTypeID);

            //The “RenderBody” method has not been called for layout page


            //This typically occurs when you: – have a partial view – use a _ViewStart.cshtml page – you call the partival view from your controller using: return View();

            //And there you go wrong.It is a partial view, so you should return like this:

            //return PartialView();

            //Source: http://www.cloud-developer.eu/blog/2014/01/20/renderbody-method-called-layout-page/

            return PartialView(destination);
        }

        // GET: Destinations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Destinations == null)
            {
                return NotFound();
            }

            var destination = await _context.Destinations
                .Include(d => d.Country)
                .FirstOrDefaultAsync(m => m.DestinationID == id);
            if (destination == null)
            {
                return NotFound();
            }

            return PartialView(destination);
        }

        // POST: Destinations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Destinations == null)
            {
                return Problem("Entity set 'ApplicationContext.Destinations'  is null.");
            }
            var destination = await _context.Destinations.FindAsync(id);
            if (destination != null)
            {
                _context.Destinations.Remove(destination);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestinationExists(int id)
        {
          return (_context.Destinations?.Any(e => e.DestinationID == id)).GetValueOrDefault();
        }
    }
}
