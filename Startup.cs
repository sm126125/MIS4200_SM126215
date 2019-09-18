using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200_SM126215.Startup))]
namespace MIS4200_SM126215
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
