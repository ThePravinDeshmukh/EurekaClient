using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Steeltoe.Common.Hosting;
using System;
using System.IO;
using Steeltoe.Common.Http.Discovery;
using Steeltoe.Discovery.Client;

namespace Eureka.Nancy.Service2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                    .UseContentRoot(Directory.GetCurrentDirectory()) // Nancy Stuff
                    .UseKestrel(o => o.AllowSynchronousIO = true) // Nancy Stuff
                    .UseStartup<Startup>();
                })
            .ConfigureAppConfiguration((hostContext, configApp) =>
            {
                configApp.AddJsonFile("appsettings.json", optional: true);
            })

            .UseCloudHosting(50502) // For Local
            ;
    }
}
