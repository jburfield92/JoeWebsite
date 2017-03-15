///////////////////////////////////////////////////////////////////////////////////////////////////
////
//// File Name: BundleConfig.cs
////
//// Date Created: 03/08/2017
////
//// Changes:
////
//// Date:          Description:
//// ----------     ------------
//// 03/08/2017     Initial
//// 03/14/2017     Added telerik bundle includes
///////////////////////////////////////////////////////////////////////////////////////////////////

using System.Web.Optimization;

namespace JoeWebsite
{
    /// <summary> javascript and css bundler
    /// </summary>
    public class BundleConfig
    {
        /// <summary> For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        /// </summary>
        /// <param name="bundles"></param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css").Include("~/Content/font-awesome.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/Kendo").Include(
                "~/Scripts/Kendo/kendo.all.min.js",
                "~/Scripts/Kendo/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/Kendo/css").Include(
                "~/Content/Kendo/kendo.common-bootstrap.min.css",
                "~/Content/Kendo/kendo.bootstrap.min.css"));

            bundles.IgnoreList.Clear();
        }
    }
}