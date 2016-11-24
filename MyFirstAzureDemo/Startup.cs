using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstAzureDemo.Startup))]
namespace MyFirstAzureDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
