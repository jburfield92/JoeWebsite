///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: MvcApplication.cs
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
using System.Web.Optimization;
using System.Web.Routing;

namespace Website
{
    /// <summary> The application start point
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary> The initial method called in the application
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
