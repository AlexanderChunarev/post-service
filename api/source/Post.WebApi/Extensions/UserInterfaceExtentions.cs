using Microsoft.Extensions.DependencyInjection;
using Post.WebApi.UseCases.Admin.Car;
using Post.WebApi.UseCases.Admin.Delivery;
using Post.WebApi.UseCases.Admin.Driver;
using Post.WebApi.UseCases.Authentication;
using Post.WebApi.UseCases.Client;
using Post.WebApi.UseCases.Order;

namespace Post.WebApi.Extensions
{
    public static class UserInterfaceV1Extensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<RegisterClientPresenter, RegisterClientPresenter>();
            services.AddScoped<Post.Application.Boundaries.Client.IOutputPort>(
                x => x.GetRequiredService<RegisterClientPresenter>()
                );

            services.AddScoped<UpdateClientPresenter, UpdateClientPresenter>();
            services.AddScoped<Post.Application.Boundaries.Client.IUpdateOutputPort>(
                x => x.GetRequiredService<UpdateClientPresenter>()
                );

            services.AddScoped<RegisterOrderPresenter, RegisterOrderPresenter>();
            services.AddScoped<Post.Application.Boundaries.Order.IOutputPort>(
                x => x.GetRequiredService<RegisterOrderPresenter>()
                );

            services.AddScoped<ClientDeparturePresenter, ClientDeparturePresenter>();
            services.AddScoped<Post.Application.Boundaries.Order.IOutputSendedOrders>(
                x => x.GetRequiredService<ClientDeparturePresenter>()
            );

            services.AddScoped<ClientReceivingPresenter, ClientReceivingPresenter>();
            services.AddScoped<Post.Application.Boundaries.Order.IOutputReceivingOrders>(
                x => x.GetRequiredService<ClientReceivingPresenter>()
            );
            
            services.AddScoped<AuthenticationPresenter, AuthenticationPresenter>();
            services.AddScoped<Post.Application.Boundaries.Authentication.IOutputPort>(
                x => x.GetRequiredService<AuthenticationPresenter>()
            );

            services.AddScoped<CreateCarPresenter, CreateCarPresenter>();
            services.AddScoped<Post.Application.Boundaries.Admin.Car.ICarOutput>(
                x => x.GetRequiredService<CreateCarPresenter>()
            );

            services.AddScoped<RegisterDriverPresenter, RegisterDriverPresenter>();
            services.AddScoped<Post.Application.Boundaries.Admin.Driver.ICreateDriverOutput>(
                x => x.GetRequiredService<RegisterDriverPresenter>()
            );

            services.AddScoped<RegisterDeliveryPresenter, RegisterDeliveryPresenter>();
            services.AddScoped<Post.Application.Boundaries.Admin.RegisterDelivery.IRegisterDeliveryOutput>(
                x => x.GetRequiredService<RegisterDeliveryPresenter>()
            );

            return services;
        }
    }
}