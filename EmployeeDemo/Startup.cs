using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeDemo.Startup))]
namespace EmployeeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
