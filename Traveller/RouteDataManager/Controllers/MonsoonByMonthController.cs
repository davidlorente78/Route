using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Data;

namespace RouteDataManager.Controllers
{
    public class MonsoonByMonthController : Controller
    {
        private readonly ApplicationContext _context;

        public MonsoonByMonthController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(MonsoonIndexByMonthViewModel monsoonIndexByMonthViewModel)
        {
            var countries = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();

            var seasonRange = _context.Ranges
                 .Where(d => d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)                
                 .Include(f => f.EntityKey_Description)
                 .ThenInclude(f => f.Items);


            var month = _context.Months.Where(x => x.MonthID == monsoonIndexByMonthViewModel.FilterMonth.MonthID).FirstOrDefault();
            monsoonIndexByMonthViewModel.FilterMonth = month;

            foreach (var country in countries)
            {
                var MonsoonRange = seasonRange.Where(x => x.CountryID == country.CountryID).Select(x => x.EntityDescription_ByMonth.Items).FirstOrDefault();

                var MonsoonDescription = MonsoonRange.Where(x => x.Key == monsoonIndexByMonthViewModel.FilterMonth.Name).Select(x => x.Value).FirstOrDefault();

                monsoonIndexByMonthViewModel.Country_MonsoonDescription.Add(country.Name, MonsoonDescription);

            }

            SelectList selectListMonth = new SelectList(_context.Months, "MonthID", "Name", monsoonIndexByMonthViewModel.FilterMonth.MonthID);

            monsoonIndexByMonthViewModel.SelectListMonth = selectListMonth;
            return PartialView(monsoonIndexByMonthViewModel);
        }
    }
}
