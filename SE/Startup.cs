using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SE.Startup))]
namespace SE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
