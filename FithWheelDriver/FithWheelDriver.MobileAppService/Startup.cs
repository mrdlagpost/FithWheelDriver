using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FithWheelDriver.MobileAppService.Startup))]

namespace FithWheelDriver.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}