using System.Web;
using System.Web.Optimization;

namespace OmegaInc.VagasEmprego.Web
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/vue")
                .Include("~/Scripts/vue.min.js")
                .Include("~/Scripts/vuex.min.js")
                .Include("~/Scripts/store.js")
                .Include("~/Scripts/vue-app.js"));

            bundles.Add(new ScriptBundle("~/bundles/material")
                .Include("~/assets/themes/material/vendors/bower_components/jquery/dist/jquery.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/tether/dist/js/tether.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/bootstrap/dist/js/bootstrap.min.js")
                .Include("~/Scripts/respond.js")
                .Include("~/assets/themes/material/vendors/bower_components/Waves/dist/waves.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/jquery.scrollbar/jquery.scrollbar.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/jquery-scrollLock/jquery-scrollLock.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/flot/jquery.flot.js")
                .Include("~/assets/themes/material/vendors/bower_components/flot/jquery.flot.resize.js")
                .Include("~/assets/themes/material/vendors/bower_components/flot.curvedlines/curvedLines.js")
                .Include("~/assets/themes/material/vendors/bower_components/jqvmap/dist/jquery.vmap.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/jqvmap/dist/maps/jquery.vmap.world.js")
                .Include("~/assets/themes/material/vendors/bower_components/jquery.easy-pie-chart/dist/jquery.easypiechart.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/salvattore/dist/salvattore.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/moment/min/moment.min.js")
                .Include("~/assets/themes/material/vendors/bower_components/fullcalendar/dist/fullcalendar.min.js")
                .Include("~/assets/themes/material/vendors/jquery.sparkline/jquery.sparkline.min.js")
                .Include("~/assets/themes/material/js/app.min.js")
                .Include("~/assets/themes/material/js/index.js")
                );

            bundles.Add(new StyleBundle("~/Content/material")
                .Include("~/assets/themes/material/vendors/bower_components/material-design-iconic-font/dist/css/material-design-iconic-font.min.css")
                .Include("~/assets/themes/material/vendors/bower_components/animate.css/animate.min.css")
                .Include("~/assets/themes/material/vendors/bower_components/jquery.scrollbar/jquery.scrollbar.css")
                .Include("~/assets/themes/material/vendors/bower_components/fullcalendar/dist/fullcalendar.min.css")
                .Include("~/assets/themes/material/css/app.min.css")                
                );
        }
    }
}
