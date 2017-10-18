using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPMS.WorkFlow.Web.Startup))]
namespace EPMS.WorkFlow.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
