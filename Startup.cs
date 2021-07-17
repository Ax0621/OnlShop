using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlShop.Startup))]
namespace OnlShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
