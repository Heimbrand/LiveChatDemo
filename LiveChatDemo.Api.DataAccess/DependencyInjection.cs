using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace LiveChatDemo.Api.DataAccess;

public static class DependencyInjection
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddScoped<IChattMessageRepository, ChatMessageRepository>();

            return services;
    }

}