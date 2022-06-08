using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day3Others.Startup))]
namespace Day3Others
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
