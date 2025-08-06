using ApiSunSale.Infrastructure.CrossCutting.Adapter;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace ApiSunSale.Infrastructure.CrossCutting.IoC
{
    public class DependencyResolverContainer : Container
    {
        private static DependencyResolverContainer _instance;

        public static DependencyResolverContainer Instance => _instance ?? (_instance = new DependencyResolverContainer());

        private DependencyResolverContainer()
        {
            //RegisterServices();
        }

        public DependencyResolverContainer(IServiceCollection services)
        {
            RegisterServices(services);
        }

        public void RegisterService<TService, TImplementation>(IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            services.AddScoped<TService, TImplementation>();
        }

        public void RegisterServices(IServiceCollection services)
        {
            #region Sevice

            RegisterService<IBlobStorageService, BlobAzureStorageService>(services);
            RegisterService<ISendGridService, SendGridService>(services);

            #endregion

            #region Application


            #endregion

            #region Repository


            #endregion

            TypeAdapterFactory.SetCurrent(new AutomapperTypeAdapterFactory());
        }
    }
}
