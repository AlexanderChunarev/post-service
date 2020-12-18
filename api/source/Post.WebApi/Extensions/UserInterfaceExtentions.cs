using Microsoft.Extensions.DependencyInjection;
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

            return services;
        }
    }
}