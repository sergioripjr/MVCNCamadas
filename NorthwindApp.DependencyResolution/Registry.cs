using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using NorthwindApp.Domain.Repositories;
using NorthwindApp.Domain.Repositories.Impl;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace NorthwindApp.DependencyResolution
{
    public class Registry
    {
        public Registry() : this(true) { }        
        public Registry(bool setup)
        {
            if (setup)
            {
                this.Setup();
            }
        }

        private void Setup()
        {
            _container = new UnityContainer();
            
            UnityConfigurationSection section =
            (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            foreach (UnityContainerElement containerConfig in section.Containers)
            {
                containerConfig.Configure(_container);
            }
            var webContextLifetimeManager = new WebContextLifetimeManager();
            _container.RegisterAssembly(typeof(ICategoryRepository).Assembly, 
                typeof(CategoryRepository).Assembly, 
                webContextLifetimeManager);
            _container.RegisterType<Domain.NorthwindEntities, Domain.NorthwindEntities>(webContextLifetimeManager, new InjectionConstructor());
        }

        private UnityContainer _container;
        private static Registry _registry;
        protected static Registry Instance
        {
            get
            {
                if (_registry == null)
                    _registry = new Registry();
                return _registry;
            }
        }

        public static T Resolve<T>()
        {
            return Registry.Instance.InnerResolve<T>();
        }
        public static object Resolve(Type type)
        {
            return Registry.Instance.InnerResolve(type);
        }

        public virtual T InnerResolve<T>()
        {
            return this._container.Resolve<T>();
        }
        public virtual object InnerResolve(Type type)
        {
            return this._container.Resolve(type);
        }
        
    }
}
