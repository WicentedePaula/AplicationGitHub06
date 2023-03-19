using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicationGitHub06.Startup))]
namespace AplicationGitHub06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
