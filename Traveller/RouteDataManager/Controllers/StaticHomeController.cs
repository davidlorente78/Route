using Microsoft.AspNetCore.Mvc;
using RouteDataManager.Models;
using System.Diagnostics;

namespace RouteDataManager.Controllers
{
    public class StaticHomeController : Controller
    {
        private readonly ILogger<StaticHomeController> _logger;

        public StaticHomeController(ILogger<StaticHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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