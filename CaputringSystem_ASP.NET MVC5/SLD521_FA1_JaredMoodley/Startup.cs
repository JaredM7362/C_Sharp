using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SLD521_FA1_JaredMoodley.Startup))]
namespace SLD521_FA1_JaredMoodley
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
