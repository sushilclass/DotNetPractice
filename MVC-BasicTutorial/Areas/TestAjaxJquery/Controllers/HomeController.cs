using MVC_BasicTutorial.Areas.TestAjaxJquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BasicTutorial.Areas.TestAjaxJquery.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /TestAjaxJquery/Home/
        public ActionResult Index()
        {
            return View();
        }

        public string GetAllCustomers()
        {
            return @"<ul>
                <li>Maria Anders</li>
                <li>Thomas Hardy</li>
                <li>Victoria Ashworth</li>
                <li>Yang Wang</li>
            </ul>";
        }
	}
}