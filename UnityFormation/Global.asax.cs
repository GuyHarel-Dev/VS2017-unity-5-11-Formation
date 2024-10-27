using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Unity;
using Unity.AspNet.Mvc;
using UnityFormation.ClassesTutor;

namespace UnityFormation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Configurer Unity
            var container = new UnityContainer();

            container.RegisterType<IMyService, MyService>();
            container.RegisterType<IMyRepository, MyRepository>();

            // Ajouter l'extension de journalisation
            container.AddExtension(new LoggingExtension());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));


        }
    }
}
