using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PhotoSharingApplication.Frontend.Client;
using PhotoSharingApplication.Frontend.Client.Core.Services;
using PhotoSharingApplication.Shared.Interfaces;
using MudBlazor.Services;
using PhotoSharingApplication.Frontend.Client.Infrastructure.Repositories.Rest;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IPhotosService, PhotosService>();
builder.Services.AddScoped<IPhotosRepository, PhotosRepository>();
await builder.Build().RunAsync();
