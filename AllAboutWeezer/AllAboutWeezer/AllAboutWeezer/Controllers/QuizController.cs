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
            var model = LoadQuestions(new WeezyTests());
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(string answer1, string answer2)
        {
            var model = LoadQuestions(new WeezyTests());
            model.UserAnswers[1] = answer1;
            model.UserAnswers[2] = answer2;
    
            var checkedModel = checkQuizAnswers(model);
            return View(checkedModel);
        }

        public QuizController()
        {
            Questions = new Dictionary<int, String>();
            Answers = new Dictionary<int, String>();
            Questions[1] = "Weezer is called Weezer because Rivers has ashma?";
            Answers[1] = "Yes";
            Questions[2] = "Rivers Cuomo still makes music";
            Answers[2] = "Yes";
        }
        public WeezyTests LoadQuestions(WeezyTests model)
        {
            model.Questions = Questions;
            model.Answers = Answers;
      
            model.UserAnswers = new Dictionary<int, string>();
            model.Results = new Dictionary<int, bool>();
     
            foreach (var question in Questions)
            {
                int key = question.Key;
                model.UserAnswers[key] = "";
            }

            return model;
        }
        public WeezyTests checkQuizAnswers(WeezyTests model)
        {
            foreach (var question in Questions)
            {
                int key = question.Key;
                model.Results[key] = model.Answers[key] == model.UserAnswers[key];
            }
            return model;
        }

    }
}
