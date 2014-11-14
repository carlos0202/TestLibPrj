using Microsoft.Practices.Unity;
using System.Web.Http;
using TestLibPrj.Models.Repositories;
using Unity.WebApi;

namespace TestLibPrj
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IBookRepository, BookRepository>(
                new HierarchicalLifetimeManager());
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}