using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApplicationHostel.Startup))]
namespace TestApplicationHostel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
