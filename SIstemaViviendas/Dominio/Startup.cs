using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dominio.Startup))]
namespace Dominio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
