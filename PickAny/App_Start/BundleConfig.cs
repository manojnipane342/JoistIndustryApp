using System.Web;
using System.Web.Optimization;

namespace PickAny
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
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/materialize/css").Include(
                    "~/Content/plugins/materialize/materialize.css",
                    "~/Content/plugins/materialize/materialize.min.css"));

            bundles.Add(new ScriptBundle("~/materialize/js").Include(
                     "~/plugins/materialize/materialize.js",
                     "~/plugins/materialize/materialize.min.js"));

            bundles.Add(new ScriptBundle("~/Assets/common").Include(
                     "~/Assets/common.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Common CSS
            bundles.Add(new ScriptBundle("~/Content/Common").Include(
                     "~/Content/Common.css"));

            //Common JS
            bundles.Add(new ScriptBundle("~/Assets/Common").Include(
                     "~/Assets/common.js"));

            //Estimate JS
            bundles.Add(new ScriptBundle("~/Assets/Estimate").Include(
                     "~/Assets/Estimate.js"));

            RegisterShared(bundles);

            RegisterLayout(bundles);

            RegisterHome(bundles);

        }

        private static void RegisterHome(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Home/DashboardV1").Include(
                "~/Scripts/DashboardV1.js"));
            bundles.Add(new ScriptBundle("~/Scripts/Home/DashboardV1/menu").Include(
                "~/Scripts/Home/DashboardV1-menu.js"));
        }

        private static void RegisterShared(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Shared/_Layout").Include(
                "~/Assets/_Layout.js"));
        }

        private static void RegisterLayout(BundleCollection bundles)
        {
            // bootstrap
            bundles.Add(new ScriptBundle("~/AdminLTE/bootstrap/js").Include(
                "~/plugins/adminlte/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/bootstrap/css").Include(
                "~/plugins/adminlte/bootstrap/css/bootstrap.min.css"));

            // dist
            bundles.Add(new ScriptBundle("~/AdminLTE/dist/js").Include(
                "~/plugins/adminlte/dist/js/app.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/dist/css").Include(
                "~/plugins/adminlte/dist/css/admin-lte.min.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/dist/css/skins").Include(
                "~/plugins/adminlte/dist/css/skins/_all-skins.min.css"));

            // documentation
            bundles.Add(new ScriptBundle("~/AdminLTE/documentation/js").Include(
                "~/plugins/adminlte/documentation/js/docs.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/documentation/css").Include(
                "~/plugins/adminlte/documentation/css/style.css"));

            // plugins | bootstrap-slider
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/bootstrap-slider/js").Include(
                                        "~/plugins/adminlte/plugins/bootstrap-slider/js/bootstrap-slider.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/bootstrap-slider/css").Include(
                                        "~/plugins/adminlte/plugins/bootstrap-slider/css/slider.css"));

            // plugins | bootstrap-wysihtml5
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/bootstrap-wysihtml5/js").Include(
                                         "~/plugins/adminlte/plugins/bootstrap-wysihtml5/js/bootstrap3-wysihtml5.all.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/bootstrap-wysihtml5/css").Include(
                                        "~/plugins/adminlte/plugins/bootstrap-wysihtml5/css/bootstrap3-wysihtml5.min.css"));

            // plugins | chartjs
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/chartjs/js").Include(
                                         "~/plugins/adminlte/plugins/chartjs/js/chart.min.js"));

            // plugins | ckeditor
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/ckeditor/js").Include(
                                         "~/plugins/adminlte/plugins/ckeditor/js/ckeditor.js"));

            // plugins | colorpicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/colorpicker/js").Include(
                                         "~/plugins/adminlte/plugins/colorpicker/js/bootstrap-colorpicker.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/colorpicker/css").Include(
                                        "~/plugins/adminlte/plugins/colorpicker/css/bootstrap-colorpicker.css"));

            // plugins | datatables
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/datatables/js").Include(
                                         "~/plugins/adminlte/plugins/datatables/js/jquery.dataTables.min.js",
                                         "~/plugins/adminlte/plugins/datatables/js/dataTables.bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/datatables/css").Include(
                                        "~/plugins/adminlte/plugins/datatables/css/dataTables.bootstrap.css"));

            // plugins | datepicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/datepicker/js").Include(
                                         "~/plugins/adminlte/plugins/datepicker/js/bootstrap-datepicker.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/datepicker/css").Include(
                                        "~/plugins/adminlte/plugins/datepicker/css/datepicker3.css"));

            // plugins | daterangepicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/daterangepicker/js").Include(
                                         "~/plugins/adminlte/plugins/daterangepicker/js/moment.min.js",
                                         "~/plugins/adminlte/plugins/daterangepicker/js/daterangepicker.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/daterangepicker/css").Include(
                                        "~/plugins/adminlte/plugins/daterangepicker/css/daterangepicker-bs3.css"));

            // plugins | fastclick
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/fastclick/js").Include(
                                         "~/plugins/adminlte/plugins/fastclick/js/fastclick.min.js"));

            // plugins | flot
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/flot/js").Include(
                                         "~/plugins/adminlte/plugins/flot/js/jquery.flot.min.js",
                                         "~/plugins/adminlte/plugins/flot/js/jquery.flot.resize.min.js",
                                         "~/plugins/adminlte/plugins/flot/js/jquery.flot.pie.min.js",
                                         "~/plugins/adminlte/plugins/flot/js/jquery.flot.categories.min.js"));

            // plugins | font-awesome
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/font-awesome/css").Include(
                                        "~/plugins/adminlte/plugins/font-awesome/css/font-awesome.min.css"));

            // plugins | fullcalendar
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/fullcalendar/js").Include(
                                         "~/plugins/adminlte/plugins/fullcalendar/js/fullcalendar.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/fullcalendar/css").Include(
                                        "~/plugins/adminlte/plugins/fullcalendar/css/fullcalendar.min.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/fullcalendar/css/print").Include(
                                        "~/plugins/adminlte/plugins/fullcalendar/css/print/fullcalendar.print.css"));

            // plugins | icheck
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/icheck/js").Include(
                                         "~/plugins/adminlte/plugins/icheck/js/icheck.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css").Include(
                                        "~/plugins/adminlte/plugins/icheck/css/all.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css/flat").Include(
                                        "~/AdminLTE/plugins/icheck/css/flat/flat.css"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/icheck/css/sqare/blue").Include(
                                        "~/plugins/adminlte/plugins/icheck/css/sqare/blue.css"));

            // plugins | input-mask
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/input-mask/js").Include(
                                         "~/plugins/adminlte/plugins/input-mask/js/jquery.inputmask.js",
                                         "~/plugins/adminlte/plugins/input-mask/js/jquery.inputmask.date.extensions.js",
                                         "~/plugins/adminlte/plugins/input-mask/js/jquery.inputmask.extensions.js"));

            // plugins | ionicons
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/ionicons/css").Include(
                                        "~/plugins/adminlte/plugins/ionicons/css/ionicons.min.css"));

            // plugins | ionslider
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/ionslider/js").Include(
                                         "~/plugins/adminlte/plugins/ionslider/js/ion.rangeSlider.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/ionslider/css").Include(
                                        "~/plugins/adminlte/plugins/ionslider/css/ion.rangeSlider.css",
                                        "~/plugins/adminlte/plugins/ionslider/css/ion.rangeSlider.skinNice.css"));

            // plugins | jquery
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jquery/js").Include(
                                         "~/plugins/adminlte/plugins/jquery/js/jQuery-2.1.4.min.js"));

            // plugins | jquery-validate
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jquery-validate/js").Include(
                                         "~/plugins/adminlte/plugins/jquery-validate/js/jquery.validate*"));

            // plugins | jquery-ui
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jquery-ui/js").Include(
                                         "~/plugins/adminlte/plugins/jquery-ui/js/jquery-ui.min.js"));

            // plugins | jvectormap
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/jvectormap/js").Include(
                                         "~/plugins/adminlte/plugins/jvectormap/js/jquery-jvectormap-1.2.2.min.js",
                                         "~/plugins/adminlte/plugins/jvectormap/js/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/jvectormap/css").Include(
                                        "~/plugins/adminlte/plugins/jvectormap/css/jquery-jvectormap-1.2.2.css"));

            // plugins | knob
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/knob/js").Include(
                                         "~/plugins/adminlte/plugins/knob/js/jquery.knob.js"));

            // plugins | morris
            bundles.Add(new StyleBundle("~/AdminLTE/plugins/morris/css").Include(
                                        "~/plugins/adminlte/plugins/morris/css/morris.css"));

            // plugins | momentjs
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/momentjs/js").Include(
                                         "~/plugins/adminlte/plugins/momentjs/js/moment.min.js"));

            // plugins | pace
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/pace/js").Include(
                                         "~/plugins/adminlte/plugins/pace/js/pace.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/pace/css").Include(
                                        "~/plugins/adminlte/plugins/pace/css/pace.min.css"));

            // plugins | slimscroll
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/slimscroll/js").Include(
                                         "~/plugins/adminlte/plugins/slimscroll/js/jquery.slimscroll.min.js"));

            // plugins | sparkline
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/sparkline/js").Include(
                                         "~/plugins/adminlte/plugins/sparkline/js/jquery.sparkline.min.js"));

            // plugins | timepicker
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/timepicker/js").Include(
                                         "~/plugins/adminlte/plugins/timepicker/js/bootstrap-timepicker.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/timepicker/css").Include(
                                        "~/plugins/adminlte/plugins/timepicker/css/bootstrap-timepicker.min.css"));

            // plugins | raphael
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/raphael/js").Include(
                                         "~/plugins/adminlte/plugins/raphael/js/raphael-min.js"));

            // plugins | select2
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/select2/js").Include(
                                         "~/plugins/adminlte/plugins/select2/js/select2.full.min.js"));

            bundles.Add(new StyleBundle("~/AdminLTE/plugins/select2/css").Include(
                                        "~/plugins/adminlte/plugins/select2/css/select2.min.css"));

            // plugins | morris
            bundles.Add(new ScriptBundle("~/AdminLTE/plugins/morris/js").Include(
                                         "~/plugins/adminlte/plugins/morris/js/morris.min.js"));

        }
    }
}
