using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using PACS.Data.Interfaces;
using PACS.Data.Mocks;
using PACS.Data.Models;
using PACS.Data;
using Microsoft.EntityFrameworkCore;
using PACS.Data.Repositories;
using Microsoft.AspNetCore.Identity;

namespace PACS
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            //Adding Appsetting json as configuartion file
            _configurationRoot = new ConfigurationBuilder().
                SetBasePath(hostingEnvironment.ContentRootPath).
                AddJsonFile("appsettings.json").
                Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Server configuration
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddTransient<IRocketRepository, RocketRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthentication();
            app.UseMvc
                (
                    routes =>
                    {
                        routes.MapRoute
                        (
                            name: "default", 
                            template:"{controller=Home}/{action=Index}/{id?}"
                        );

                        routes.MapRoute
                        (
                            name: "categoryFilter",
                            template: "Rocket/{action}/{category?}",
                            defaults: new { Controller = "Rocket", action = "List" }
                        );
                    }
                );

            DbInitializer.Seed(serviceProvider);
        }
    }
}
