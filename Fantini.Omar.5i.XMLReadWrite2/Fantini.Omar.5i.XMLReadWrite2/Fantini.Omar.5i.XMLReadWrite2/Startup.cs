using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fantini.Omar._5i.XMLReadWrite2.Startup))]
namespace Fantini.Omar._5i.XMLReadWrite2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
