using System.Web;
using System.Web.Optimization;

namespace EPMS.WorkFlow.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
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
                      "~/Scripts/moment.min.js",
                      "~/Scripts/bootstrap-datepicker/js/bootstrap-datepicker.min.js",
                      "~/Scripts/bootstrap-colorpicker.min.js",
                      "~/Scripts/daterangepicker.js",
                      "~/Scripts/raphael.min.js",
                      "~/Scripts/morris.min.js",
                       "~/Scripts/datatables.net/jquery.dataTables.min.js",
                       "~/Scripts/datatables.net-bs/dataTables.bootstrap.min.js",
                      "~/Scripts/jquery.sparkline.min.js",
                      "~/Scripts/jquery.knob.min.js",
                      "~/Scripts/Chart.min.js",
                      "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                      "~/Scripts/jquery-jvectormap-world-mill-en.js",
                      "~/Scripts/jquery.slimscroll.min.js",
                      "~/Scripts/bootstrap3-wysihtml5.all.min.js",
                      "~/Scripts/adminlte.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-datepicker/bootstrap-datepicker.min.css",
                      "~/Content/bootstrap-colorpicker/bootstrap-colorpicker.min.css",
                       "~/Content/bootstrap-daterangepicker/daterangepicker.css",
                       "~/Content/datatables.net-bs/dataTables.bootstrap.min.css",
                       "~/Content/jquery-jvectormap.css",
                       "~/Content/morris.css",
                      "~/Content/bootstrap3-wysihtml5.min.css",
                      "~/Content/font-awesome/css/font-awesome.min.css",
                      "~/Content/css/AdminLTE.min.css",
                      "~/Content/css/skins/_all-skins.min.css",
                      "~/Content/font-awesome/css/font-awesome.min.css",
                      "~/Content/Ionicons/css/ionicons.min.css"
                      ));
        }
    }
}
