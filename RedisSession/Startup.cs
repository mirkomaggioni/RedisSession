using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedisSession.Startup))]
namespace RedisSession
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
