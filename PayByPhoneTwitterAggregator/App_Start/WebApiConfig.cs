using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PayByPhoneTwitterAggregator
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // matches /api/twitter/{action}/id
            config.Routes.MapHttpRoute(
                name: "DefaultApi2",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional },
                constraints: new { controller = "twitter" }
            );

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
