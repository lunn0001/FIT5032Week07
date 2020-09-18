using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week07.Startup))]
namespace Week07
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
