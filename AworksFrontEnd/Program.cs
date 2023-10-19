using AworksFontEnd;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


//builder.Services.
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(MyAllowSpecificOrigins,
//                          policy =>
//                          {
//                              policy.WithOrigins("http://example.com",
//                                                  "http://www.contoso.com")
//                                                  .AllowAnyHeader()
//                                                  .AllowAnyMethod();
//                          });
//});

//builder.RootComponents.add
//options.AddPolicy("CorsPolicy", builder => builder.WithOrigins("http://<YOUR_URL>")//The client Url that wants to get data
//                .AllowAnyHeader()
//                .AllowAnyMethod()
//                .AllowCredentials()
//                .SetIsOriginAllowed((host) => true));




//app.UseCors(policy =>
//    policy.WithOrigins("http://localhost:5000", "https://localhost:5001")
//    .AllowAnyMethod()
//    .WithHeaders(HeaderNames.ContentType));

//var app = builder.Build();
//app.UseHttpsRedirection();
//app.UseCors("CorsPolicy");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
