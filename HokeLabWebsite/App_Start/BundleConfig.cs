using System.Web;
using System.Web.Optimization;

namespace HokeLabWebsite
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-responsive.css"));

            bundles.Add(new StyleBundle("~/Content/core-css")
                .Include("~/Content/GeneratedCss/BaseStyles.css"));
        }
     }
}