using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Tutorial.BlazorMovies.Client.Helpers;

namespace Tutorial.BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            ConfigureServices(builder.Services); //Call configuration

            builder.Services.AddScoped(
                sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection service)
        {
            service.AddOptions(); //Authorization System
            service.AddSingleton<SingletonService>();
            service.AddTransient<TransientService>();
            service.AddTransient<IRepository, RepositoryInMemory>();
        }
    }
}