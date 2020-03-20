using System.Web;
using System.Web.Optimization;

namespace Pharmacy_System
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // Hazem Script bundels
            bundles.Add(new ScriptBundle("~/bundles/HazemScripts").Include(
                      "~/Scripts/HazemScripts/jquery.min.js",
                      "~/Scripts/HazemScripts/bootstrap.bundle.min.js",
                      "~/Scripts/HazemScripts/jquery.easing.min.js",
                      "~/Scripts/HazemScripts/sb-admin-2.min.js",
                      "~/Scripts/HazemScripts/Chart.min.js",
                      "~/Scripts/HazemScripts/chart-area-demo.js",
                      "~/Scripts/HazemScripts/chart-pie-demo.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Hazem Css bundles
            bundles.Add(new StyleBundle("~/Content/HazemCss").Include(
                      "~/Content/HazemCss/all.min.css",
                      "~/Content/HazemCss/sb-admin-2.min.css",
                      "~/Content/HazemCss/fontAwesome.css"));
        }
    }
}
