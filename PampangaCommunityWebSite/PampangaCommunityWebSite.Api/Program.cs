using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using PampangaCommunityWebSite.Client.Entities;
using PampangaCommunityWebSite.Client.Models;
using PampangaCommunityWebSite.Client.ViewModels;
using System.Diagnostics;

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
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.MapRazorPages();

app.MapPost("/send-contact-message", async (ContactFormData data) => 
{
    Debug.WriteLine($"Receive a contact from {data.Email}");
    await Task.Delay(3000);
    return Results.Ok();
});

app.MapFallbackToPage("/_Host");

await app.RunAsync();