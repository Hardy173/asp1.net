﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebStore1.Infrastructure.Implementations;
using WebStore1.Infrastructure.Implementations;
using WebStore1.Infrastructure.Interfaces;

namespace WebStore1
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
       
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IEmployeesData, InMemoryEmployeesData>();

            services.AddSingleton<IProductData, InMemoryProductData>();

        }

        

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseWelcomePage("/welcome");

            // Добавляем обработку запросов в mvc-формате
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
