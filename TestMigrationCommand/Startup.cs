using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMigrationCommand.Startup))]
namespace TestMigrationCommand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
