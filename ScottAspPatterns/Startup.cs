using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScottAspPatterns.Startup))]
namespace ScottAspPatterns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
