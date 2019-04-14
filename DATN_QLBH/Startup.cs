using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DATN_QLBH.Startup))]
namespace DATN_QLBH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
