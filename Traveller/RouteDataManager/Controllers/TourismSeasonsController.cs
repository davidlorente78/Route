﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using StaticData;

namespace RouteDataManager.Controllers
{
    public class TourismSeasonsController : Controller
    {
        private readonly ApplicationContext _context;

        public TourismSeasonsController(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(Month_EntityByCountryIndexViewModel month_EntityByCountryIndexViewModel)
        {
            var seasonRange = _context.Ranges
                 .Where(d => d.CountryID == month_EntityByCountryIndexViewModel.FilterCountry.CountryID && d.RangeType.Code==RangeTypes.TourismSeasonRangeType.Code)
                 .Include(f => f.EntityKey_ByMonth).ThenInclude(x => x.Dictionary)
                 .Include(f => f.EntityKey_Description).ThenInclude(x => x.Dictionary).FirstOrDefault();

            if (seasonRange != null)
            {
                //Para cada mes
                foreach (var item in seasonRange.EntityKey_ByMonth.Dictionary)
                {
                    var Month = item.DictionaryKey;
                    var SeasonDescription = seasonRange.EntityKey_Description.Dictionary.Where(x => (x.DictionaryKey).ToString() == item.DictionaryValue).Select(x => x.DictionaryValue).First();
                    month_EntityByCountryIndexViewModel.Month_EntityDescription.Add(Month, SeasonDescription);
                }
            }
            else {
                month_EntityByCountryIndexViewModel.Month_EntityDescription = new Dictionary<string, string>();
            }

            SelectList selectListCountries = new SelectList(_context.Countries, "CountryID", "Name", month_EntityByCountryIndexViewModel.FilterCountry.CountryID);

            month_EntityByCountryIndexViewModel.SelectListCountries = selectListCountries;
            return PartialView(month_EntityByCountryIndexViewModel);
        }

    }
}