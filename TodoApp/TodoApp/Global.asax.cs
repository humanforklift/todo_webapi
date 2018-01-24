using System.Web.Http;

namespace TodoApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			TodoRepository.Init( );
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
