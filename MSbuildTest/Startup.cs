using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSbuildTest.Startup))]
namespace MSbuildTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
