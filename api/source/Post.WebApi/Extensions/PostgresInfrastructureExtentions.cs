using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Post.Application.Repositories;
using Post.Application.Repositories.Client;
using Post.Application.Repositories.Order;
using Post.Infrastructure.DapperDataAccess.Repositories;
using Post.Infrastructure.DapperDataAccess.Repositories.Order;

namespace Post.WebApi.Extensions
{
    public static class PostgresInfrastructureExtensions
    {
        public static IServiceCollection AddPostgresPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(
                options => new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")));

            // Add repositories below
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
    }
}