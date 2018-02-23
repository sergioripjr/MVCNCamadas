using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindApp.Controllers
{
    public class ControllerFactory : System.Web.Mvc.DefaultControllerFactory
    {
        protected override IController GetControllerInstance(Type controllerType)
        {
            if (controllerType != null)
            {
                return (IController)DependencyResolution.Registry.Resolve(controllerType);
            }
            return base.GetControllerInstance(controllerType);
        }
    }
}
