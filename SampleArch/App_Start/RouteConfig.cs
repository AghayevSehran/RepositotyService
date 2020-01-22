using System.Web.Mvc;
using System.Web.Routing;

namespace SampleArch
{
    public class RouteConfig
    {
        //https://techbrij.com/generic-repository-unit-testing-ioc-di-asp-net-mvc
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Country", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
