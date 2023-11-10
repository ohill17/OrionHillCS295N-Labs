using Microsoft.AspNetCore.Mvc;

namespace AllAboutWeezer.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public QuizQuestions LoadQuestions (QuizQuestions model)
    }
}
