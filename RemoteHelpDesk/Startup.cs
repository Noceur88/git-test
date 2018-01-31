using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemoteHelpDesk.Startup))]
namespace RemoteHelpDesk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
