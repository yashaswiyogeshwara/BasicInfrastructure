using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicInfrastructure.Startup))]
namespace BasicInfrastructure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
