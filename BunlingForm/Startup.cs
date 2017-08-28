using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BunlingForm.Startup))]
namespace BunlingForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
