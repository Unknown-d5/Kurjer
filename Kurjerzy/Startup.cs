using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kurjerzy.Startup))]
namespace Kurjerzy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
