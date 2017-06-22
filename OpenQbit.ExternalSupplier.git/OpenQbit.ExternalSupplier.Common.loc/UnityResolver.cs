using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OpenQbit.ExternalSupplier.Dal.DataAccess;
using OpenQbit.ExternalSupplier.Dal.Contracts;



namespace OpenQbit.ExternalSupplier.Common.loc
{
    public static class UnityResolver 
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        public static void Register()
        {
            
           Container.RegisterType<IRepository,Repository>();
           // Container.RegisterType<ILogger, Logger>();
        }
        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer GetContainer()
        {
            return Container;
        }

    }


}