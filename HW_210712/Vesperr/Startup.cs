using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vesperr.Models;

namespace Vesperr
{
    public class Startup
    {
        private readonly IConfiguration _contig;
        public Startup(IConfiguration contig)
        {
            _contig = contig;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<VesperrContext>(opt =>
            {
                opt.UseSqlServer(_contig.GetConnectionString("Default"));
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=home}/{action=index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    "default2",
                    "{controller=home}/{action=index}/{id?}"
                    );
            });
        }
    }
}
