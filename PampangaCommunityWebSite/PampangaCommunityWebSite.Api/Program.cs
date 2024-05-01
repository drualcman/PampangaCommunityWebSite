using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using PampangaCommunityWebSite.Entities.Models;
using PampangaCommunityWebSite.BusinessLogic.Interfaces.SendContactMessage;
using PampangaCommunityWebSite.Client.Models;
using PampangaCommunityWebSite.Client.ViewModels;
using PampangaCommunityWebsite.MailService.Smtp.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSingleton<HttpClient>(sp =>
{
    var server = sp.GetRequiredService<IServer>();
    var addressFeatures = server.Features.Get<IServerAddressesFeature>();
    string baseAddress = addressFeatures.Addresses.First();
    return new HttpClient() { BaseAddress = new Uri(baseAddress) };
});
builder.Services.AddScoped<ContactPageModel>();
builder.Services.AddScoped<ContactPageViewModel>();
builder.Services.AddUseCases();
builder.Services.AddMailServices(options => builder.Configuration.GetSection(SmtpOptions.SectionKey).Bind(options));
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.MapRazorPages();

app.MapPost("/send-contact-message", async (ContactFormData data,
    ISendContactMessageController controller) => await controller.SendMessage(data));

app.MapFallbackToPage("/_Host");

await app.RunAsync();