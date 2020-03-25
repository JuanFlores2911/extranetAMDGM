using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(extAMDGM.Web.Startup))]
namespace extAMDGM.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
