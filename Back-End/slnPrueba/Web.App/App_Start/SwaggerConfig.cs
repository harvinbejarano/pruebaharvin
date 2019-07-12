using System.Web.Http;
using WebActivatorEx;
using Web.App;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Web.App
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
           .EnableSwagger(c => c.SingleApiVersion("v1", "API"))
           .EnableSwaggerUi();
        }
    }
}
