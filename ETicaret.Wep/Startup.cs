using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETicaret.Wep.Startup))]
namespace ETicaret.Wep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
