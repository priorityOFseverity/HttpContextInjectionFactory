using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using InjectionFactory.App_Start;
using Unity;

namespace InjectionFactory.Infrastructure
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            var key = $"{controllerName}Controller";
            if (UnityResolver.Container.IsRegistered<IController>(key))
            {
                return UnityResolver.Container.Resolve<IController>(key);
            }
            return base.CreateController(requestContext, controllerName);
        }
    }
}