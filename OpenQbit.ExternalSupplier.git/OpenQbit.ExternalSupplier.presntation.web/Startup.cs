using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQbit.ExternalSupplier.presntation.web.Startup))]
namespace OpenQbit.ExternalSupplier.presntation.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
