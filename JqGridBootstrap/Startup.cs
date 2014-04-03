using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqGridBootstrap.Startup))]
namespace JqGridBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
