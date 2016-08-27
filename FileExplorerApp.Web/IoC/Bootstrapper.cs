using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FileExplorerApp.Common;
using System.Web.Http;
using System.Web.Mvc;
using FileExplorerApp.Repository;
using FileExplorerApp.Core.Services;
using FileExplorerApp.Core.Services.Impl;

namespace FileExplorerApp.Web.Ioc
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise(HttpConfiguration httpConfig)
        {
            var container = BuildUnityContainer();

            var dependencyResolver = new UnityResolver(container);
            DependencyResolver.SetResolver(dependencyResolver);
            httpConfig.DependencyResolver = dependencyResolver;

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container =  IoC.Instance;
          
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            RegisterServices(container);
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IFileSystem, FileSystemBrowser>();
            container.RegisterType<IDirectoryBrowserService, DirectoryBrowserService>();
            //container.RegisterType<IUserAccessController, UserAccessController>();
            //container.RegisterType<IBankAcountDataService, BankAcountDataService>();
            //container.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();
            //container.RegisterType<IHashProvider, MD5Hash>();
        }
    }
}