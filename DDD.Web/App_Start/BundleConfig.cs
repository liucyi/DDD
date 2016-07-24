using System.Web;
using System.Web.Optimization;

namespace DDD.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            #region MyRegion
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #endregion
            #region Css
            //MetroNic
            bundles.Add(new StyleBundle("~/Bundles/MetroNic/mandatory/css")
                .Include("~/fonts/font-google/opensans.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/uniform/css/uniform.default.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css", new CssRewriteUrlTransform())
                );
            //Themes
            bundles.Add(new StyleBundle("~/Bundles/MetroNic/ThemeStyle/css")
                .Include("~/assets/global/css/components.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/css/plugins.min.css", new CssRewriteUrlTransform())
                );
            //页面布局
            bundles.Add(new StyleBundle("~/Bundles/MetroNic/ThemeLayout/css")
                .Include("~/assets/layouts/layout/css/layout.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/layouts/layout/css/themes/blue.css", new CssRewriteUrlTransform())
                .Include("~/assets/layouts/layout/css/custom.min.css", new CssRewriteUrlTransform())
                .Include("~/assets/global/plugins/jstree/dist/themes/default/style.css", new CssRewriteUrlTransform())
                );
            #endregion
            #region Js
            //主要js
            bundles.Add(
                new ScriptBundle("~/Bundles/MetroNic/CorePlugins/js")
                    .Include(
                        "~/assets/global/plugins/jquery.min.js",
                        "~/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                        "~/assets/global/plugins/js.cookie.min.js",
                        "~/assets/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                        "~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/assets/global/plugins/jquery.blockui.min.js",
                        "~/assets/global/plugins/uniform/jquery.uniform.min.js",
                        "~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js"
                    ));
            bundles.Add(
                new ScriptBundle("~/Bundles/MetroNic/PageLevelPlugins/js")
                    .Include(
                        "~/assets/global/plugins/moment.min.js",
                        "~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.js",
                        "~/assets/global/plugins/morris/morris.min.js",
                        "~/assets/global/plugins/morris/raphael-min.js",
                        "~/assets/global/plugins/counterup/jquery.waypoints.min.js",
                        "~/assets/global/plugins/counterup/jquery.counterup.min.js",

                        "~/assets/global/plugins/flot/jquery.flot.min.js",
                        "~/assets/global/plugins/flot/jquery.flot.resize.min.js",
                        "~/assets/global/plugins/flot/jquery.flot.categories.min.js",
                        "~/assets/global/plugins/jquery-easypiechart/jquery.easypiechart.min.js",
                        "~/assets/global/plugins/jquery.sparkline.min.js",
                        "~/assets/global/plugins/jstree/dist/jstree.min.js",
                        //页面切换
                        "~/assets/myplugins/js/TransitionLoder.js"

                    ));
            bundles.Add(
                new ScriptBundle("~/Bundles/MetroNic/ThemeLayout/js")
                    .Include(
                        "~/assets/global/scripts/app.min.js",
                        "~/assets/pages/scripts/dashboard.min.js",
                        "~/assets/layouts/layout/scripts/layout.min.js",
                        "~/assets/layouts/layout/scripts/demo.min.js",
                        "~/assets/layouts/global/scripts/quick-sidebar.min.js"
                    // ,//临时添加 jstree加载
                    //"~/assets/myplugins/js/JSTree.js"
                    ));
            bundles.Add(
                new ScriptBundle("~/Bundles/MetroNic/HChart/js")
                    .Include(
                        "~/assets/global/plugins/Highcharts/js/highcharts.js",
                        "~/assets/global/plugins/Highcharts/js/modules/exporting.js",
                        "~/assets/global/plugins/Highcharts/js/highcharts-more.js",
                        "~/assets/global/plugins/Highcharts/js/modules/solid-gauge.js"
                    ));
            #endregion
        }
    }
}
