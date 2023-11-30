using AllAboutWeezer.Data;
using AllAboutWeezer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AllAboutWeezer.Controllers
{
    public class HomeController : Controller
    {
        IForumRepository repository;
        public HomeController(IForumRepository r)
        {
            repository = r;
        }

        // TODO: Do something interesting with the messageId
        public IActionResult StoriesPost(string messageId)
        {
            // Get the last post out of the database
            var messages = repository.GetMessages();
            // .Where(m => m.MessageId == int.Parse(messageId))
            // .FirstOrDefault();
            // .Find(int.Parse(messageId));
            return View(messages);
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


            // Save model to db
            int result;
            result = repository.StoreMessage(model);

            return RedirectToAction("StoriesPost", new { model.MessageId });
        }
        public IActionResult Privacy()
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