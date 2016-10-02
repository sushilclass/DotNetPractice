using System.Web.Mvc;

namespace MVC_BasicTutorial.Areas.ProductList
{
    public class ProductListAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ProductList";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ProductList_default",
                "ProductList/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}