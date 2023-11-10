using Microsoft.AspNetCore.Mvc;

namespace AllAboutWeezer.Controllers
{
    public class SourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
