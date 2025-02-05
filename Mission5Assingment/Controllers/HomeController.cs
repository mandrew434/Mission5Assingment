using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission5Assingment.Models;

namespace Mission5Assingment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // This method returns the Index view
        public IActionResult Index()
        {
            return View();
        }

        // This method returns the Services view
        public IActionResult Services()
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
