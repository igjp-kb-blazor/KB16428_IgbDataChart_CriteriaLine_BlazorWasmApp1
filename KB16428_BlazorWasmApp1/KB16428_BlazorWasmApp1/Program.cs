using IgniteUI.Blazor.Controls;
using KB16428_BlazorWasmApp1;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor(
    typeof(IgbDataChartCoreModule),
    typeof(IgbDataChartCategoryModule),
    typeof(IgbDataChartCategoryCoreModule),
    typeof(IgbDataChartInteractivityModule),
    typeof(IgbColumnSeriesModule),
    typeof(IgbValueOverlayModule),
    typeof(IgbDataChartAnnotationModule)
);

await builder.Build().RunAsync();
