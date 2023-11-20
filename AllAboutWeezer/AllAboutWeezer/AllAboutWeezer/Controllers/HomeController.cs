using AllAboutWeezer.Data;
using AllAboutWeezer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AllAboutWeezer.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext context;
        public HomeController(AppDbContext c)
        {
            context = c;
        }

        // TODO: Do something interesting with the messageId
        public IActionResult StoriesPost(string messageId)
        {
            // Get the last post out of the database
            var model = context.Message
                
                .ToList();
           //Where(m => m.MessageId == int.Parse(messageId))
            // .FirstOrDefault();
            // .Find(int.Parse(messageId));
            return View(model);
        }

        private readonly ILogger<HomeController> _logger;

     

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
            context.Message.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index", new { model.MessageId });
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