using com.educacionit.ms.pet.services.ImplementServices;
using com.educacionit.ms.pet.services.Interfaces;
using System.Data.Entity;
using System.Web.Http;
using Unity;

namespace com.educacionit.ms.mvc.pet.App_Start
{
    public static class WebApiConfig
    {

        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(

                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}