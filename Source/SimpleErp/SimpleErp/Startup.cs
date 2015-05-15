using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleErp.Startup))]
namespace SimpleErp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
