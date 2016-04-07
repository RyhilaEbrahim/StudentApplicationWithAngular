﻿using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Padca.Woodgrove.Web.Bootstrappers.Ioc;

namespace StudentApplication.Web.Bootstrappers.Ioc.Installers
{
    public class WindsorFactoryInstallers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<IControllerFactory>()
                    .ImplementedBy<WindsorControllerFactory>()
                    .LifeStyle.Singleton
                );

           
        }
    }
}