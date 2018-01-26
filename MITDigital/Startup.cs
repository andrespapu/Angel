using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MITDigital.Startup))]
namespace MITDigital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
