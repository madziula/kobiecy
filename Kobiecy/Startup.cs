using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kobiecy.Startup))]
namespace Kobiecy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
