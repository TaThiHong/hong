using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWeb1.Startup))]
namespace TestWeb1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
