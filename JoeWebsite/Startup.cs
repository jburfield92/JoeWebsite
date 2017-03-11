using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JoeWebsite.Startup))]
namespace JoeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
