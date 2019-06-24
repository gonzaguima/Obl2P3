using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIstemaViviendas.Startup))]
namespace SIstemaViviendas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
