///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: Global.asax.cs
////
//// Date Created: 03/08/2016
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

namespace JoeWebsite
{
    /// <summary> Global application class
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
