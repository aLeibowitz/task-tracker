using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(task_tracker.Startup))]
namespace task_tracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
