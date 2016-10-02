using System.Web.Mvc;

namespace MVC_BasicTutorial.Areas.TestAjaxJquery
{
    public class TestAjaxJqueryAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TestAjaxJquery";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TestAjaxJquery_default",
                "TestAjaxJquery/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}