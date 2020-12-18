using Microsoft.Extensions.DependencyInjection;
using Post.Application.UseCases.Client.OrderByClient;
using Post.Application.UseCases.Client.Register;
using Post.Application.UseCases.Client.Update;
using Post.Application.UseCases.Order.Register;
using Post.Application.UseCases.Parcel;

namespace Post.WebApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IRegisterClientUseCase, RegisterClientUseCase>();
            services.AddScoped<IUpdateClientUseCase, UpdateClientUseCase>();
            services.AddScoped<IRegisterOrderUseCase, RegisterOrderUseCase>();
            services.AddScoped<ClientSendedOrdersUseCase>();
            services.AddScoped<ClientReceivingUseCase>();
            services.AddScoped<ICreateParcelUseCase, CreateParcelUseCase>();

            return services;
        }
    }
}

