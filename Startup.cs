using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApp6.Startup))]
namespace TestApp6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
