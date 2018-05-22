using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AAARent_ASP.Startup))]
namespace AAARent_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
