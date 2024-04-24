using PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;
using PampangaCommunityWebSite.BusinessLogic.UseCases.SendContactMessage;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<ISendContactMessageInputPort, SendContactMessageInteractor>();
        services.AddScoped<ISendContactMessageController, SendContactMessageController>();
        return services;
    }
}
