using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("sensor" ,client =>
{
    client.BaseAddress = new Uri("https://my-wonderful-api-acgvdvaaa5d4bez.northeurope-01.azurewebsites.net");
});
builder.Services.AddHttpClient("myApi", client =>
{
    client.BaseAddress = new Uri("http://localhost:5062/");
});

await builder.Build().RunAsync();
