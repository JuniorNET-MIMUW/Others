using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRepo.Startup))]
namespace WebRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
