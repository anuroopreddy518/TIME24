using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TIME24.Startup))]
namespace TIME24
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
