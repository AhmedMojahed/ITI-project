using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iti_project.Startup))]
namespace iti_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
