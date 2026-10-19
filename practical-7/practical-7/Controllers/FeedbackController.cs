using Microsoft.AspNetCore.Mvc;
using practical_7.Models;

namespace practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(feedbackList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.Id = nextId++;
                feedbackList.Add(feedback);

                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}