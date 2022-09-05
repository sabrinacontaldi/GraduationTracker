using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Hosting;

namespace Blazor_CoursePlanner
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }

    // private static void CreateDbIfNotExists(IHost host)
    // {
    //     using (var scope = host.Services.CreateScope())
    //     {
    //         var services = scope.ServiceProvider;
    //         var context = services.GetRequiredService<CoursePlannerContext>();
    //         // context.Database.EnsureCreated();
    //         DbInitializer.Initialize(context);
    //     }
    // }

    // public static IHostBuilder CreateHostBuilder(string[] args) =>
    //   Host.CreateDefaultBuilder(args)
    //     .ConfigureWebHostDefaults(webBuilder =>
    //     {
    //       webBuilder.UseStartup<Startup>();
    //     });        
  
    }
    
}


