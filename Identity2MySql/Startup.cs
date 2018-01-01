using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identity2MySql.Startup))]
namespace Identity2MySql
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
