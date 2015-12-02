using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyLich.Startup))]
namespace QuanLyLich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
