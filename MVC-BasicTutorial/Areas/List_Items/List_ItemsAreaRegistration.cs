using System.Web.Mvc;

namespace MVC_BasicTutorial.Areas.List_Items
{
    public class List_ItemsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "List_Items";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "List_Items_default",
                "List_Items/{controller}/{action}/{id}",
                new { controller="List_Items/Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}