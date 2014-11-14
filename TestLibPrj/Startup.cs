using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestLibPrj.Startup))]
namespace TestLibPrj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
