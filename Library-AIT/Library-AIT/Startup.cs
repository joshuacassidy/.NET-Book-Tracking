using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Library_AIT.Startup))]
namespace Library_AIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
