using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InjectionFactory.Controllers;
using InjectionFactory.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using Unity;

namespace InjectionFactory.App_Start
{
    public class UnityResolver : IDependencyResolver
    {
        public static UnityContainer Container { get; set; } = new UnityContainer();

        static UnityResolver()
        {
            Container.RegisterType<IController, HomeController>("HomeController");

            Container.RegisterType<IControllerFactory, CustomControllerFactory>();
            Container.RegisterType<System.Security.Principal.IIdentity>(new Unity.Injection.InjectionFactory(_ => HttpContext.Current.User.Identity));
        }

        public object GetService(Type serviceType)
        {
            return Container.Resolve(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.ResolveAll(serviceType);
        }
    }
}