using Blazored.LocalStorage;
using LiteraryWings_Administrador;
using LiteraryWings_Administrador.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.LiteraryWings.somee.com/api/") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://www.backend.com/api/") });

builder.Services.AddMudServices(); //Importación de los servicios de MudBlazor

builder.Services.AddScoped<UserAuth>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
