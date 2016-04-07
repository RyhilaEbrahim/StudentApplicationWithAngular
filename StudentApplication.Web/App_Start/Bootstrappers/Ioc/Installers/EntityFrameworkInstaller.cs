using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using StudentApplication.DB;

namespace StudentApplication.Web.Bootstrappers.Ioc.Installers
{
    public class EntityFrameworkInstaller : IWindsorInstaller
    {
        private Func<ComponentRegistration<IStudentDbContext>, ComponentRegistration<IStudentDbContext>> _lifestyleConfiguration;

        public EntityFrameworkInstaller()
        {
            _lifestyleConfiguration = ConfigureLifestylePerRequest;
        }
        public EntityFrameworkInstaller(
            Func<ComponentRegistration<IStudentDbContext>, ComponentRegistration<IStudentDbContext>> lifestyleConfiguration)
        {
            _lifestyleConfiguration = lifestyleConfiguration;
        }

        private ComponentRegistration<IStudentDbContext> ConfigureLifestylePerRequest(ComponentRegistration<IStudentDbContext> componentRegistration)
        {
            return componentRegistration.LifestylePerWebRequest();
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(_lifestyleConfiguration(Component.For<IStudentDbContext>()
                .ImplementedBy<StudentDbContext>()));
        }
    }
}