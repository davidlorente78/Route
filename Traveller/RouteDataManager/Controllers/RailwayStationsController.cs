using Domain.Messages;
using Domain.Transport.Railway;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;

namespace RouteDataManager.Controllers
{
    public class RailwayStationsController : Controller, IConsumer<DestinationCreated>
    {
        private readonly ApplicationContext _context;

        public RailwayStationsController(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(StationIndexViewModel stationIndexViewModel)
        {
            IOrderedQueryable<RailwayStation>? applicationContext;
            IQueryable<RailwayLine>? itemsSelectLines = _context.RailwayLines;

            if (stationIndexViewModel.FilterCountry.Id != 0)
            {
                itemsSelectLines = _context.RailwayLines.Where(l => l.CountryID == stationIndexViewModel.FilterCountry.Id);
                stationIndexViewModel.FilterLine = itemsSelectLines.FirstOrDefault();
                applicationContext = _context.RailwayStations
                    .Where(
                        s => s.Destinations.Select(d => d.CountryId).Contains(stationIndexViewModel.FilterCountry.Id)
                     )
                    .Include(s => s.Destinations)
                    .OrderBy(s => s.RailwayStationID);
            }
            else
            {
                applicationContext = _context.RailwayStations.Include(s => s.Destinations).OrderBy(s => s.Name);
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "Id", "Name", stationIndexViewModel.FilterCountry.Id);
            SelectList selectListLines = new SelectList(itemsSelectLines.ToList(), "RailwayLineID", "Name", stationIndexViewModel.FilterLine.RailwayLineID);

            stationIndexViewModel.SelectListCountries = selectListCountries;
            stationIndexViewModel.SelectListLines = selectListLines;
            stationIndexViewModel.Stations = await applicationContext.ToListAsync();

            return PartialView(stationIndexViewModel);
        }



        public JsonResult GetLinesListByCountryID(int CountryID)
        {
            //https://www.findandsolve.com/articles/cascading-dropdownlist-in-net-core-5
            //https://www.rafaelacosta.net/Blog/2019/11/24/c%C3%B3mo-crear-un-cascading-dropdownlist-en-aspnet-mvc

            List<RailwayLine>? data = _context.RailwayLines.Where(l => l.CountryID == CountryID).ToList();

            var selectList = new SelectList(data, "RailwayLineID", "Name");
            return Json(selectList);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RailwayStations == null)
            {
                return NotFound();
            }

            var station = await _context.RailwayStations
                .FirstOrDefaultAsync(m => m.RailwayStationID == id);
            if (station == null)
            {
                return NotFound();
            }

            return View(station);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RailwayStationID,Name,LocalName,Type,Remarks")] RailwayStation station)
        {
            if (ModelState.IsValid)
            {
                _context.Add(station);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(station);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RailwayStations == null)
            {
                return NotFound();
            }

            var station = await _context.RailwayStations.FindAsync(id);
            if (station == null)
            {
                return NotFound();
            }
            return View(station);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RailwayStationID,Name,LocalName,Type,Remarks")] RailwayStation station)
        {
            if (id != station.RailwayStationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(station);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StationExists(station.RailwayStationID))
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
            return View(station);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RailwayStations == null)
            {
                return NotFound();
            }

            var station = await _context.RailwayStations
                .FirstOrDefaultAsync(m => m.RailwayStationID == id);
            if (station == null)
            {
                return NotFound();
            }

            return View(station);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RailwayStations == null)
            {
                return Problem("Entity set 'ApplicationContext.Station'  is null.");
            }
            var station = await _context.RailwayStations.FindAsync(id);
            if (station != null)
            {
                _context.RailwayStations.Remove(station);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StationExists(int id)
        {
            return (_context.RailwayStations?.Any(e => e.RailwayStationID == id)).GetValueOrDefault();
        }

        public Task Consume(ConsumeContext<DestinationCreated> context)
        {
            //TODO
            //Create Station from Destination Created Message
            //Check DestinationTypeId

            var destinationId = context.Message.Id; //ID station is needed here

            var station = new RailwayStation()
            {
                Name = context.Message.Name,
                Remarks = context.Message.Message,

            };

            //Repo Destination
            var destination =  _context.Destinations.Find(destinationId);

            station.Destinations.Add(destination);
            _context.Add(station);
            return  _context.SaveChangesAsync();

        }
    }
}
