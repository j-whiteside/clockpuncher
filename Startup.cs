using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(landlorder2.Startup))]
namespace landlorder2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
