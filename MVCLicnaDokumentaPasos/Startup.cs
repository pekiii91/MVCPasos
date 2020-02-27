using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLicnaDokumentaPasos.Startup))]
namespace MVCLicnaDokumentaPasos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
