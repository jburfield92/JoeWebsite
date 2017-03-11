///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: RouteConfig.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.Web.Mvc;
using System.Web.Routing;

namespace JoeWebsite
{
    /// <summary> API Route Configuration
    /// </summary>
    public class RouteConfig
    {
        /// <summary> Register API Routes
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