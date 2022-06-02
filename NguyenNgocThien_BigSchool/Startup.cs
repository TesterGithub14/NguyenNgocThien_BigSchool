using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenNgocThien_BigSchool.Startup))]
namespace NguyenNgocThien_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
