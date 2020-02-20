﻿
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeManagementOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Employee", id = UrlParameter.Optional }
            );
        }
    }
}