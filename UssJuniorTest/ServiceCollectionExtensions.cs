using UssJuniorTest.Infrastructure.Repositories;
using UssJuniorTest.Infrastructure.Store;

namespace UssJuniorTest;

public static class ServiceCollectionExtensions
{
    public static void RegisterAppServices(this IServiceCollection services)
    {
        services.AddSingleton<IStore, InMemoryStore>();

        services.AddScoped<CarRepository>();
        services.AddScoped<PersonRepository>();
    }
}