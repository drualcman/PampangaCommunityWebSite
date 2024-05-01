using PampangaCommunityWebsite.MailService.Smtp.Options;
using PampangaCommunityWebsite.MailService.Smtp.Services;
using PampangaCommunityWebSite.BusinessLogic.Interfaces;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddMailServices(this IServiceCollection services,
        Action<SmtpOptions> configureOptions)
    {
        services.Configure(configureOptions);
        services.AddScoped<IMailService, MailService>();
        return services;
    }
}
