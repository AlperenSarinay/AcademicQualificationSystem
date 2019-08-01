using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ceng382Lab.Startup))]
namespace Ceng382Lab
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
