using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;

namespace LoadViewFromAssembly.Factory
{
    public static class AssemblyRoute
    {
        public static void MapRoutes(this RouteCollection routes, Assembly assembly)
        {
            ControllerBuilder.Current.SetControllerFactory(new AssemblyControllerFactory(assembly));
            HostingEnvironment.RegisterVirtualPathProvider(new AssemblyVirtualPathProvider(assembly));
        }
    }
}