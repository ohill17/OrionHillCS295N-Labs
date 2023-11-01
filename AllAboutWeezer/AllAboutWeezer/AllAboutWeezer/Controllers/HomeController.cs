using AllAboutWeezer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllAboutWeezer.Controllers
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

        public IActionResult History()
        {
            return View();
        }
        public IActionResult Stories()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Stories(Message model)
        {
            model.Date = DateOnly.FromDateTime(DateTime.Now);

            return View("StoriesPost", model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult StoriesPost()
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