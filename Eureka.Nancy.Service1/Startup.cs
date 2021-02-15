using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nancy.Owin;
using Steeltoe.Common.Http.Discovery;
using Steeltoe.Discovery.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eureka.Nancy.Service1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Eureka - inject client config
            //services.AddConfigurationDiscoveryClient(Configuration);
            services.AddDiscoveryClient(Configuration);

            // Eureka - service name
            //services.AddHttpClient("someservice", client => client.BaseAddress = new Uri("http://someservice/")).AddServiceDiscovery();


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Eureka - app pipeline
            app.UseDiscoveryClient();

            
            app.UseOwin(x => x.UseNancy());
        }
    }
}
