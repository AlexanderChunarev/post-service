using Microsoft.Extensions.DependencyInjection;
using Post.Application.UseCases.Client;

namespace Post.WebApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IRegisterClientUseCase, RegisterClientUseCase>();

            return services;
        }
    }
}

