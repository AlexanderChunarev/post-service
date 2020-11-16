using Microsoft.Extensions.DependencyInjection;
using Post.Application.UseCases.Example;

namespace Post.WebApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAddExampleUseCase, AddExampleUseCase>();

            return services;
        }
    }
}

