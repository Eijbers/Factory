using Factory.Factory.Models.Factory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            //Command pattern DI
            builder.Services.AddTransient<RailRoadLogistics>(); 
            builder.Services.AddTransient<RoadLogistics>();
            builder.Services.AddTransient<SeaLogistics>();

            using IHost host = builder.Build();

            host.RunAsync();
        }
    }
}