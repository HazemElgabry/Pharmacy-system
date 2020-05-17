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

            /*
             * Project Scripts
             */
            bundles.Add(new ScriptBundle("~/bundles/ProjectScripts").Include(
                       "~/Scripts/Project_Scripts/jquery.min.js",
                       "~/Scripts/Project_Scripts/bootstrap.bundle.min.js",
                       "~/Scripts/Project_Scripts/fastclick.js",
                       "~/Scripts/Project_Scripts/nprogress.js",
                       "~/Scripts/Project_Scripts/Chart.min.js",
                       "~/Scripts/Project_Scripts/gauge.min.js",
                       "~/Scripts/Project_Scripts/bootstrap-progressbar.min.js",
                       "~/Scripts/Project_Scripts/icheck.min.js",
                       "~/Scripts/Project_Scripts/skycons.js",
                       "~/Scripts/Project_Scripts/jquery.flot.js",
                       "~/Scripts/Project_Scripts/jquery.flot.pie.js",
                       "~/Scripts/Project_Scripts/jquery.flot.time.js",
                       "~/Scripts/Project_Scripts/jquery.flot.stack.js",
                       "~/Scripts/Project_Scripts/jquery.flot.resize.js",
                       "~/Scripts/Project_Scripts/jquery.flot.orderBars.js",
                       "~/Scripts/Project_Scripts/jquery.flot.spline.min.js",
                       "~/Scripts/Project_Scripts/curvedLines.js",
                       "~/Scripts/Project_Scripts/date.js",
                       "~/Scripts/Project_Scripts/jquery.vmap.js",
                       "~/Scripts/Project_Scripts/jquery.vmap.world.js",
                       "~/Scripts/Project_Scripts/jquery.vmap.sampledata.js",
                       "~/Scripts/Project_Scripts/moment.min.js",
                       "~/Scripts/Project_Scripts/daterangepicker.js",
                       "~/Scripts/Project_Scripts/custom.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            /*
             * Project Css
             */
            bundles.Add(new StyleBundle("~/Content/ProjectCss").Include(
                     "~/Content/Project_Content/bootstrap.min.css",
                     "~/Content/Project_Content/font-awesome.min.css",
                     "~/Content/Project_Content/nprogress.css",
                     "~/Content/Project_Content/green.css",
                     "~/Content/Project_Content/bootstrap-progressbar-3.3.4.min.css",
                     "~/Content/Project_Content/jqvmap.min.css",
                     "~/Content/Project_Content/daterangepicker.css",
                     "~/Content/Project_Content/custom.min.css"));
        }
    }
}
