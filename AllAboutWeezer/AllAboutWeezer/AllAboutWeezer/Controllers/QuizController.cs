using AllAboutWeezer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllAboutWeezer.Controllers
{
    public class QuizController : Controller
    {
        public Dictionary<int, String> Questions { get; set; }
        public Dictionary<int, String> Answers { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public WeezyTests LoadQuestions(WeezyTests model)
        {
            //Temporary hardcoded question
            //in the future export XML
            //TODO: load questions and answers 
            //into the model
            return model;
        }
    }
}
