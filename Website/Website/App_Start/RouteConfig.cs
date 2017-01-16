///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: RouteConfig.cs
////
//// Date Created: 12/17/2016
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 12/17/2016     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;
using System.Web.Routing;

namespace Website
{
    /// <summary> Configures the routes
    /// </summary>
    public class RouteConfig
    {
        /// <summary> Registers the routes
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
