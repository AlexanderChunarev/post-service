using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Post.Application.Repositories.Car;
using Post.Application.Repositories.Client;
using Post.Application.Repositories.Deliver;
using Post.Application.Repositories.Driver;
using Post.Application.Repositories.Order;
using Post.Application.Repositories.Parcel;
using Post.Infrastructure.DapperDataAccess.Repositories.Client;
using Post.Infrastructure.DapperDataAccess.Repositories.Order;
using Post.Infrastructure.Repositories.Car;
using Post.Infrastructure.Repositories.Delivery;
using Post.Infrastructure.Repositories.Driver;
using Post.Infrastructure.Repositories.Parcel;

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
            services.AddScoped<IParcelRepository, ParcelRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<IDeliveryRepository, DeliveryRepository>();
            return services;
        }
    }
}