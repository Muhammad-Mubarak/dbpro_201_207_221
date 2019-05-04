using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(medical_encyclopedia_DB62.Startup))]
namespace medical_encyclopedia_DB62
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
