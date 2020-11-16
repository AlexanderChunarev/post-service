using Microsoft.Extensions.DependencyInjection;
using Post.WebApi.UseCases.Login;

namespace Post.WebApi.Extensions
{
    public static class UserInterfaceV1Extensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ExamplePresenter, ExamplePresenter>();
            services.AddScoped<Post.Application.Boundaries.Example.IOutputPort>(
                x => x.GetRequiredService<ExamplePresenter>());

            return services;
        }
    }
}