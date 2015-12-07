using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeLab_PW2015.Startup))]
namespace CodeLab_PW2015
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
