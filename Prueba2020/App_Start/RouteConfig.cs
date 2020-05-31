using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Prueba2020
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            RouteTable.Routes.MapRoute(
                name: "eCommerceCategoryView",
                url: "stock/add/{nombre}/{descripcion}/{tipo}/{stock}",
                new { controller = "Stock", action = "Add"});
        }
    }
}
