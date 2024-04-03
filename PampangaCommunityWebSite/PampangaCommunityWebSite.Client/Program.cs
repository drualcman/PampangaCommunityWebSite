using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PampangaCommunityWebSite.Client.Models;
using PampangaCommunityWebSite.Client.ViewModels;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ContactPageModel>();
builder.Services.AddScoped<ContactPageViewModel>();

await builder.Build().RunAsync();
