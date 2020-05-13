using System.Web.Mvc;

namespace HavaalaniOtomasyonuApp.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {

            context.MapRoute(
              name: "Admin_Login",
              url: "Admin",
              defaults: new { controller = "Login", action = "Index" }
          );

            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}