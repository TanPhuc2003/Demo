using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo1.Controllers
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
            return View();
        }

        public IActionResult Information()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }
        public IActionResult Subject()
        {
            return View();
        }
        public IActionResult FQA()
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
