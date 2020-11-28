using Microsoft.Extensions.DependencyInjection;
using Post.WebApi.UseCases.Client;

namespace Post.WebApi.Extensions
{
    public static class UserInterfaceV1Extensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<RegisterClientPresenter, RegisterClientPresenter>();
            services.AddScoped<Post.Application.Boundaries.Client.IOutputPort>(
                x => x.GetRequiredService<RegisterClientPresenter>());

            return services;
        }
    }
}