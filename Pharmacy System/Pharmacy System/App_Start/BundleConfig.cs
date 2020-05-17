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
                       "~/Content/Project_Content/bootstrap-progressbar.min.js",
                       "~/Content/Project_Content/icheck.min.js",
                       "~/Content/Project_Content/skycons.js",
                       "~/Content/Project_Content/jquery.flot.js",
                       "~/Content/Project_Content/jquery.flot.pie.js",
                       "~/Content/Project_Content/jquery.flot.time.js",
                       "~/Content/Project_Content/jquery.flot.stack.js",
                       "~/Content/Project_Content/jquery.flot.resize.js",
                       "~/Content/Project_Content/jquery.flot.orderBars.js",
                       "~/Content/Project_Content/jquery.flot.spline.min.js",
                       "~/Content/Project_Content/curvedLines.js",
                       "~/Content/Project_Content/date.js",
                       "~/Content/Project_Content/jquery.vmap.js",
                       "~/Content/Project_Content/jquery.vmap.world.js",
                       "~/Content/Project_Content/jquery.vmap.sampledata.js",
                       "~/Content/Project_Content/moment.min.js",
                       "~/Content/Project_Content/daterangepicker.js",
                       "~/Content/Project_Content/custom.min.js"));

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
