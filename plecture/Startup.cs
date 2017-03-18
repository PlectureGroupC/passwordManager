using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(plecture.Startup))]
namespace plecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
