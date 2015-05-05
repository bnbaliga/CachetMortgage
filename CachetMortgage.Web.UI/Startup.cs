using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CachetMortgage.Web.UI.Startup))]
namespace CachetMortgage.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
