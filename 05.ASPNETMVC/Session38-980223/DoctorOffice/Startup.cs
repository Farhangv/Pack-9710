using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoctorOffice.Startup))]
namespace DoctorOffice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
