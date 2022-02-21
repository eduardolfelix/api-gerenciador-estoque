using GerEstoque.Api.Ioc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerEstoque.Api.Utils
{
    public static class ExtentionUtils
    {
        public static void AddProjectServices(this IServiceCollection services, IConfiguration configuration)
            => RegisterServices.Register(services, configuration);
    }
}