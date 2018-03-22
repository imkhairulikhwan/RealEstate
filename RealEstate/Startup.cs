using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;
using RealEstate.Data;
using Microsoft.AspNetCore.Identity;
using RealEstate.Services;

namespace RealEstate
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

			services.AddIdentity<ApplicationUser, IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

			// Add application services.
			services.AddTransient<IEmailSender, EmailSender>();

			services.AddAuthentication().AddFacebook(facebookOptions =>
			{
				//facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
				//facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];

				facebookOptions.AppId = "152060522222780";
				facebookOptions.AppSecret = "b7c8e2f593fc8973d07eb3f1772f3c09";
			});

			services.AddMvc();			

            //var connection = @"Server=(localdb)\mssqllocaldb;Database=RealEstate;Trusted_Connection=True;ConnectRetryCount=0";
			var connection = @"Data Source=SQL6003.site4now.net;Initial Catalog=DB_A31034_navinest;User Id=DB_A31034_navinest_admin;Password=P@ssw0rd;";
            services.AddDbContext<RealEstateContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
            else
            {
                app.UseExceptionHandler("/Index/Error");
            }

            app.UseStaticFiles();

			app.UseAuthentication();

			app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Index}/{action=Index}/{id?}");
            });
        }
    }
}
