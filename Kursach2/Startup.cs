using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kursach2.Startup))]
namespace Kursach2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
