using ApiSunSale.Infrastructure.CrossCutting.IoC;

namespace ApiSunSale.Presentation.Api.App_Start
{
    public class DependencyResolverConfig
    {
        public static void Register(WebApplicationBuilder app)
        {
            _ = new DependencyResolverContainer(app.Services);
        }
    }
}
