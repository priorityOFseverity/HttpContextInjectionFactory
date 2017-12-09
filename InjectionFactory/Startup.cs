using InjectionFactory.App_Start;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InjectionFactory.Startup))]
namespace InjectionFactory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //UnityResolver.Container.Resolve();
            ConfigureAuth(app);
        }
    }
}
