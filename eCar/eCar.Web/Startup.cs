using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eCar.Web.Startup))]
namespace eCar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
