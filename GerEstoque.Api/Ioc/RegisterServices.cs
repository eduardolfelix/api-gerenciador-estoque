using GerEstoque.Api.Contexts;
using GerEstoque.Api.Repositories.CategoriaRepository;
using GerEstoque.Api.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerEstoque.Api.Ioc
{
    public static class RegisterServices
    {
        public static void Register(IServiceCollection serviceCollection, IConfiguration configuration){

            // Api Services
            serviceCollection.AddScoped<ICategoriaService, CategoriaService>();

            //Api Repositories
            serviceCollection.AddScoped<ICategoriaRepository, CategoriaRepository>();

            serviceCollection.AddDbContext<GerEstoqueContext>(options => 
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}