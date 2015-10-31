using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebUI.SysSala.Startup))]
namespace WebUI.SysSala
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
