using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoAppWithBackand.Startup))]
namespace TodoAppWithBackand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
