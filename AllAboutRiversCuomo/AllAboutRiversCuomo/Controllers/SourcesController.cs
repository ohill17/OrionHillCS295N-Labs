using Microsoft.AspNetCore.Mvc;

namespace AllAboutRiversCuomo.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
