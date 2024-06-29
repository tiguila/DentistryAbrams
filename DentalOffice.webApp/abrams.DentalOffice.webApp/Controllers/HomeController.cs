using abrams.DentalOffice.webApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace abrams.DentalOffice.webApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // This just a timestap for the copyright year. Pass a timestap so that the Razor view get the current year to display in the copyright line.
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["CurrentTimestamp"] = DateTime.Now;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
