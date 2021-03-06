using Microsoft.Extensions.DependencyInjection;
using Post.Application.UseCases.Admin;
using Post.Application.UseCases.Admin.Car;
using Post.Application.UseCases.Admin.Driver;
using Post.Application.UseCases.Authentication;
using Post.Application.UseCases.Client.OrderByClient;
using Post.Application.UseCases.Client.Register;
using Post.Application.UseCases.Client.Update;
using Post.Application.UseCases.Order.Register;

namespace Post.WebApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IRegisterClientUseCase, RegisterClientUseCase>();
            services.AddScoped<IUpdateClientUseCase, UpdateClientUseCase>();
            services.AddScoped<IRegisterOrderUseCase, RegisterOrderUseCase>();
            services.AddScoped<IAuthenticationUserUseCase, AuthenticationUserUseCase>();
            services.AddScoped<ClientSendedOrdersUseCase>();
            services.AddScoped<ClientReceivingUseCase>();
            services.AddScoped<ICreateCarUseCase, CreateCarUseCase>();
            services.AddScoped<IRegisterDriverUseCase, RegisterDriverUseCase>();
            services.AddScoped<IRegisterDeliveryUseCase, RegisterDeliveryUseCase>();

            return services;
        }
    }
}

