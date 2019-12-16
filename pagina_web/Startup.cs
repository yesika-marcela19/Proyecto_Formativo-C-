using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pagina_web.Startup))]
namespace pagina_web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
