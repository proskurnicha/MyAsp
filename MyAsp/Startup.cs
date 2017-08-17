using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAsp.Startup))]
namespace MyAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
