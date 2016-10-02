using System;
using System.Web.Mvc;
using System.Collections.Generic;
using MVC_BasicTutorial.Areas.List_Items.Models;

namespace MVC_BasicTutorial.Areas.List_Items.Models
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new SampleViewModel());
        }


        [HttpPost]
        public JsonResult GetAnswer(string question)
        {
            int index = _rnd.Next(_db.Count);
            var answer = _db[index];
            return Json(answer);
        }

        private static Random _rnd = new Random();

        private static List<string> _db = new List<string> { "Yes", "No", "Definitely, yes", "I don't know", "Looks like, yes" };
    }
}