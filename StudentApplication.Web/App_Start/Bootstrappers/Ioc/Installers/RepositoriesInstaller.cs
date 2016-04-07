using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using StudentApplication.Core.Interfaces;
using StudentApplication.DB.Repositories;

namespace Padca.Woodgrove.Web.Bootstrappers.Ioc.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IStudentRepository>()
                .ImplementedBy<StudentRepository>()
                .LifestyleTransient());
            container.Register(Component.For<ICityRepsitory>()
                .ImplementedBy<CityRepository>()
                .LifestyleTransient());
          
        }
    }
}