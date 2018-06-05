using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineTestSystemUI.Startup))]
namespace OnlineTestSystemUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
