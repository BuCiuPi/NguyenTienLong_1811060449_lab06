using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTienLong_1811060449_lab06.Startup))]
namespace NguyenTienLong_1811060449_lab06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
