using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitPart4.Startup))]
namespace gitPart4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
