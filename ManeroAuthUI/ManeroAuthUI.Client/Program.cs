using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://manero-users.azurewebsites.net") });

await builder.Build().RunAsync();
