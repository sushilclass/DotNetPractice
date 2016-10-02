using MVC_BasicTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BasicTutorial.Controllers
{
    public class MemberController : Controller
    {
        List<Member> memberList = new List<Member>() { 
                    new Member(){ MemberId = 1, MemberName = "Sushil Kumar", MemberAddress = "Ghaziabad", MemberAge = 34},
                    new Member(){ MemberId = 2, MemberName = "Anil Kumar",   MemberAddress = "Moradabad", MemberAge = 32},
                    new Member(){ MemberId = 3, MemberName = "Vipul Kumar",  MemberAddress = "Lucknow",   MemberAge = 25},
                    new Member(){ MemberId = 4, MemberName = "Amit Sharma",  MemberAddress = "Meerut",    MemberAge = 23},
                   new Member(){ MemberId = 5, MemberName = "Kapil Goyel",  MemberAddress = "Jhasi",    MemberAge = 30},
                };

        public ActionResult Index()
        {
            return View(memberList);
        }

        public ActionResult Edit(int MemberId)
        {
            //Get the student from studentList sample collection for demo purpose.
            //You can get the student from the database in the real application
            var std = memberList.Where(s => s.MemberId == MemberId).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Member std)
        {
            //write code to update student 

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Membership()
        {

            return View();
        }

        [HttpPost]
        public ViewResult Membership(MVC_BasicTutorial.Models.Member formdata)
        {
            return View("Thanks", formdata);
        }

    }
}
