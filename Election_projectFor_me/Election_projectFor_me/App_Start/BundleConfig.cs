using System.Web;
using System.Web.Optimization;

namespace Election_projectFor_me
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // You can also include the CSS files in a similar way if needed
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/assets/css/animate.css",
                "~/assets/css/swiper-bundle.min.css",
                "~/assets/css/magnific-popup.css",
                "~/assets/css/leaflet.css",
                "~/assets/css/leaflet-routing-machine.css",
                "~/assets/css/style.css"
            ));

            BundleTable.EnableOptimizations = true;
        }
    }
}
