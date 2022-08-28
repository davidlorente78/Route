using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;

namespace RouteDataManager.Controllers
{
    public class TourismSeasonsByMonthController : Controller
    {
        private readonly ApplicationContext _context;

        public TourismSeasonsByMonthController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(SeasonIndexByMonthViewModel seasonIndexByMonthViewModel)
        {
            var countries = _context.Countries.Include(x => x.Ranges).Where(x => x.Ranges.Count != 0).ToList();
            var seasonRange = _context.Ranges
                 .Where(d => d.RangeType.Code == 'S')
                 .Include(f => f.EntityKey_ByMonth)
                 .ThenInclude(f => f.Items)                
                 .Include(f => f.EntityKey_Description)
                 .ThenInclude(f => f.Items);


            var month = _context.Months.Where(x => x.MonthID == seasonIndexByMonthViewModel.FilterMonth.MonthID).FirstOrDefault();
            seasonIndexByMonthViewModel.FilterMonth = month;

            
            foreach (var country in countries) 
            {               
                    var Season = seasonRange.Where(x => x.CountryID == country.CountryID).Select(x => x.EntityKey_ByMonth.Items.Where(d => d.Key == seasonIndexByMonthViewModel.FilterMonth.Name).FirstOrDefault());

                    if (Season.Count() != 0) {
                        var SeasonDictionary = Season.ToDictionary(x => x.Key, x => x.Value);

                        string StringSeasonChar = SeasonDictionary.GetValueOrDefault(seasonIndexByMonthViewModel.FilterMonth.Name);

                        char SeasonChar = StringSeasonChar.ToCharArray()[0];


                        var SeasonDescriptions = seasonRange.Where(x => x.CountryID == country.CountryID).Select(x => x.EntityKey_Description).FirstOrDefault();

                        var SeasonDescriptionsDictionary = SeasonDescriptions.Items.ToDictionary(x => x.Key, x => x.Value);


                        var SeasonDescription = SeasonDescriptionsDictionary.GetValueOrDefault(SeasonChar);

                        seasonIndexByMonthViewModel.Country_SeasonDescription.Add(country.Name, SeasonDescription);
                    }
              
            }

            SelectList selectListMonth = new SelectList(_context.Months, "MonthID", "Name", seasonIndexByMonthViewModel.FilterMonth.MonthID);


            seasonIndexByMonthViewModel.SelectListMonth= selectListMonth;
            return PartialView(seasonIndexByMonthViewModel);
        }


    }
}
