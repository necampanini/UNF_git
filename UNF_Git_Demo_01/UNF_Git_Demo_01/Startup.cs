using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UNF_Git_Demo_01.Startup))]
namespace UNF_Git_Demo_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
