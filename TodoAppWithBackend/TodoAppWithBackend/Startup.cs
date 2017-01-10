using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoAppWithBackend.Startup))]
namespace TodoAppWithBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
