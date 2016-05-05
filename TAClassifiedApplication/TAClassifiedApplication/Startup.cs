using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAClassifiedApplication.Startup))]
namespace TAClassifiedApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
