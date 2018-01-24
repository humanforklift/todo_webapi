using System.Net.Http.Headers;
using System.Web.Http;

namespace TodoApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
	        config.Formatters.JsonFormatter.SupportedMediaTypes
		        .Add(new MediaTypeHeaderValue("text/html") );

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /*config.Routes.MapHttpRoute(
                name: "Location",
                routeTemplate: "api/{controller}/{id}/{location}",
                defaults: new { id = RouteParameter.Optional, location = RouteParameter.Optional }
            );*/
        }
    }
}
