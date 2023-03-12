using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DistributedSystems2020 {
    public class RouteConfig {
        public static void RegisterRoutes( RouteCollection routes ) {
            routes.IgnoreRoute( "{resource}.axd/{*pathInfo}" );

            routes.MapRoute(
                name: "About",
                url: "За-нас",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "Контакти",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Weather",
                url: "Време",
                defaults: new { controller = "Home", action = "Weather", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Nameday",
                url: "Именици",
                defaults: new { controller = "Home", action = "Nameday", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Exchange",
                url: "Валути",
                defaults: new { controller = "Home", action = "Exchange", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Artist",
                url: "Музиканти",
                defaults: new { controller = "Home", action = "Artist", id = UrlParameter.Optional }
            );

                routes.MapRoute(
                name: "Movie",
                url: "Филми",
                defaults: new { controller = "Home", action = "Movie", id = UrlParameter.Optional }
            );

                routes.MapRoute(
                name: "Hero",
                url: "Герои",
                defaults: new { controller = "Home", action = "Hero", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "IndexHome",
                url: "Винетки",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "IndexCars",
                url: "е-Книги",
                defaults: new { controller = "Cars", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Create",
                url: "Създай",
                defaults: new { controller = "Cars", action = "Create", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Delete",
                url: "Изтрий",
                defaults: new { controller = "Cars", action = "Delete", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Details",
                url: "Детайли",
                defaults: new { controller = "Cars", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Edit",
                url: "Промени",
                defaults: new { controller = "Cars", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
