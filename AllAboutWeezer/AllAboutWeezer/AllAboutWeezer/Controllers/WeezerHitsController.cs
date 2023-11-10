using Microsoft.AspNetCore.Mvc;

namespace AllAboutWeezer.Controllers
{
    public class WeezerHitsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
