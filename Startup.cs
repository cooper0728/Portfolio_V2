using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portfolio_v2.Startup))]
namespace Portfolio_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
