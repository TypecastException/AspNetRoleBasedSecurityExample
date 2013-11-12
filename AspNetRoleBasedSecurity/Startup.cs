using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetRoleBasedSecurity.Startup))]
namespace AspNetRoleBasedSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
