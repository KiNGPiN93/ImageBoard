using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageBoard.Startup))]
namespace ImageBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
