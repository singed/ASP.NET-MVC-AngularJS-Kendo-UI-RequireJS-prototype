using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Owin;
using MvcAngularKendoRequire;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace MvcAngularKendoRequire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
