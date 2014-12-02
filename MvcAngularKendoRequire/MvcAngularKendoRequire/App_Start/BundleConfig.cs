using System.Web.Optimization;

namespace MvcAngularKendoRequire
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libs/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/libs/bootstrap.js"
            ));


            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                    "~/Scripts/libs/kendo/kendo.all.min.js"
           ));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/Scripts/libs/angular/angular.js",
                     "~/Scripts/libs/angular/angular-route.js",
                     "~/Scripts/libs/angular/angular-sanitize.js",
                     "~/Scripts/libs/angular/angular-route.js",
                     "~/Scripts/libs/angular/angular-animate.js"
            ));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/theme/bootstrap.css",
                      "~/Content/css/theme/bootstrap-theme.css",
                      "~/Content/css/theme/font-awesome.css",
                      "~/Content/css/theme/kendo.common.min.css",
                      "~/Content/css/theme/kendo.common-bootstrap.min.css",
                      "~/Content/css/theme/kendo.bootstrap.min.css",
                      "~/Content/css/theme/sb-admin-2.css"));
        }
    }
}
