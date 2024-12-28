using Example.Core.Repositories;
using Example.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL;

public static class ServiceRegistration 
{
   public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>(); 
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<IProductRepository, ProductRepository>(); 

        return services;
    }
}
