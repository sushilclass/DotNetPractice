using MVC_BasicTutorial.Areas.ProductList.BO;
using MVC_BasicTutorial.Areas.ProductList.DAL;
using MVC_BasicTutorial.Areas.ProductList.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_BasicTutorial.Areas.ProductList.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /ProductList/Home/
        ProductBO productBO = new ProductBO();
        public ActionResult GetProductCategories()
        {

            ViewBag.CategoryType = new SelectList(productBO.getAllCategories(), "Id", "Name");

            return View();
        }

        public JsonResult getProductsByCategory(string id)
        {

            List<Product> products = productBO.getProductByCategory(id);
           
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}