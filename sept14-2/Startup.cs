using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sept14_2.Startup))]
namespace sept14_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
