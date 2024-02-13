using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BE_U1_W3_D2.Startup))]
namespace BE_U1_W3_D2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
