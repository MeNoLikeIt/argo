using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Argo.mvc.Startup))]
namespace Argo.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
