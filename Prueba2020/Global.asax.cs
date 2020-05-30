using LightInject;
using Prueba2020.Service.Interface;
using Prueba2020.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Service = Prueba2020.Service.Composer;
namespace Prueba2020
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = new ServiceContainer();
            //register other services
            container.Register<IStock, StockService>(new PerScopeLifetime());
        }
    }
}
