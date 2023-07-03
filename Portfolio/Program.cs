using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;
using BlazorTransitionableRoute;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddScoped<IRouteTransitionInvoker, DefaultRouteTransitionInvoker>();
builder.Services.AddBlazorise()
    .AddBulmaProviders()
    .AddFontAwesomeIcons();

await builder.Build()
    .RunAsync();
