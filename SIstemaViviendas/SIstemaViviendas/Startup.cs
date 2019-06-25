using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaViviendas.Startup))]
namespace SistemaViviendas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
