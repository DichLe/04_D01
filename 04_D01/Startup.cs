using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04_D01.Startup))]
namespace _04_D01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
