using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNet.Base1.Startup))]
namespace ASPNet.Base1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
