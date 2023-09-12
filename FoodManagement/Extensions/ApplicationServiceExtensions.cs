using FoodManagement.Application.Handler;
using FoodManagement.Core.Repository;
using FoodManagement.Core.Repository.Base;
using FoodManagement.Infrastracture.Data;
using FoodManagement.Infrastracture.Repository;
using FoodManagement.Infrastracture.Repository.Base;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace FoodManagement.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddSwaggerGen();
            services.AddControllers();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(typeof(CreateMenuCommandHandler).GetTypeInfo().Assembly) ;
            services.AddMediatR(typeof(GetMenuQueryHandler).GetTypeInfo().Assembly) ;
            services.AddDbContext<FoodContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddScoped(typeof(IMenuRepository),typeof(MenuRepository));

            return services;
        }
    }
}
