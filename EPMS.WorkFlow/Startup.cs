using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPMS.WorkFlow.Startup))]
namespace EPMS.WorkFlow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
