using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyThirdTime.Startup))]
namespace VidlyThirdTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
