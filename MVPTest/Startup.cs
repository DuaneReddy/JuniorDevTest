using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVPTest.Startup))]
namespace MVPTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
