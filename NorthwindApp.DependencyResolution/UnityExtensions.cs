using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Reflection;

namespace NorthwindApp.DependencyResolution
{
    internal static class UnityExtensions
    {

        public static void RegisterAssembly(this UnityContainer container, Assembly contractAssembly, Assembly implementationAssembly)
        {
            RegisterAssembly(container, contractAssembly, implementationAssembly, new ContainerControlledLifetimeManager());
        }

        public static void RegisterAssembly(this UnityContainer container, Assembly contractAssembly, Assembly implementationAssembly, LifetimeManager lifetimeManager)
        {
            foreach (var contractType in contractAssembly.GetTypes())
            {
                foreach (var implementationType in implementationAssembly.GetTypes())
                {
                    if (contractType.IsInterface && contractType.IsAssignableFrom(implementationType))
                    {
                        container.RegisterType(contractType, implementationType);
                    }                    
                }                
            }
        }

  

    }
}
