﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteDataManager.Models;
using RouteDataManager.Repositories;
using RouteDataManager.ViewModels;
using System.Diagnostics;
using Traveller.Domain;
using Traveller.DomainServices;

namespace RouteDataManager.Controllers
{
    public class DynamicHomeController : Controller
    {
        private readonly ILogger<DynamicHomeController> _logger;
        private readonly ICountryService countryService;
        private readonly ApplicationContext _context;

       

        public DynamicHomeController(ApplicationContext context,ICountryService countryService,ILogger<DynamicHomeController> logger)
        {
            _logger = logger;
            _context = context;
            this.countryService = countryService;
        }

        public IActionResult Index()
        {
            DynamicIndexData dynamicIndexData = new DynamicIndexData();

            var countriesOrderedByShowInDynamicHomeOrder = _context.Countries.Where(c => c.ShowInDynamicHome == true).Include(c => c.Destinations).OrderBy(c=>c.ShowInDynamicHomeOrder);

            foreach (Country country in countriesOrderedByShowInDynamicHomeOrder) { 
            
                dynamicIndexData.CountryNames.Add(country.Name);
                dynamicIndexData.DestinationCountryCount.Add(country.Destinations.Count);
            
            
            }
            return View(dynamicIndexData);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}