using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAsp.Net_Primeros_Pasos.Startup))]
namespace WebAsp.Net_Primeros_Pasos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
