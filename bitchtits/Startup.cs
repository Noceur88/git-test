using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bitchtits.Startup))]
namespace bitchtits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
