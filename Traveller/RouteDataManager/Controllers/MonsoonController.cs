using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using Data.EntityTypes;


namespace RouteDataManager.Controllers
{
    public class MonsoonController : Controller
    {
        private readonly ApplicationContext _context;

        public MonsoonController(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(Month_EntityByCountryIndexViewModel month_EntityByCountryIndexViewModel)
        {
            
            var seasonRange = _context.Ranges
                 .Where(d => d.CountryID == month_EntityByCountryIndexViewModel.FilterCountry.CountryID && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
                 .Include(f => f.EntityDescription_ByMonth).ThenInclude(x => x.Items).FirstOrDefault();

            if (seasonRange != null)
            {
                //Para cada mes
                foreach (var item in seasonRange.EntityDescription_ByMonth.Items)
                {
                    var Month = item.Key;
                    var Description = item.Value;
                    month_EntityByCountryIndexViewModel.Month_EntityDescription.Add(Month, Description);
                }
            }
            else {
                month_EntityByCountryIndexViewModel.Month_EntityDescription = new Dictionary<string, string>();
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", month_EntityByCountryIndexViewModel.FilterCountry.CountryID);

            month_EntityByCountryIndexViewModel.SelectListCountries = selectListCountries;
            return PartialView(month_EntityByCountryIndexViewModel);
        }

        public async Task<IActionResult> Seasons(Month_EntityByCountryIndexViewModel month_EntityByCountryIndexViewModel)
        {
            var seasonRange = _context.Ranges
                 .Where(d => d.CountryID == month_EntityByCountryIndexViewModel.FilterCountry.CountryID && d.RangeType.Code == RangeTypes.MonsoonSeasonRangeType.Code)
                 .Include(f => f.EntityKey_Description).ThenInclude(x => x.Items).FirstOrDefault();

            if (seasonRange != null)
            {
                //Para cada Key
                foreach (var item in seasonRange.EntityKey_Description.Items)
                {
                    var Key = item.Key;
                    var Description = item.Value;
                    month_EntityByCountryIndexViewModel.Month_EntityDescription.Add(Key.ToString(), Description);
                }
            }
            else
            {
                month_EntityByCountryIndexViewModel.Month_EntityDescription = new Dictionary<string, string>();
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", month_EntityByCountryIndexViewModel.FilterCountry.CountryID);

            month_EntityByCountryIndexViewModel.SelectListCountries = selectListCountries;
            return PartialView("Index",month_EntityByCountryIndexViewModel);
        }

    }
}
