using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ATravelersGuideToSerdan.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ATravelersGuideToSerdan.Services;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;
using System;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.Extensions.Hosting;

namespace ATravelersGuideToSerdan
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddReact();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllersWithViews();

            services.AddTransient<ISerdan, SqlSerdan>();
            services.AddTransient<IFileSerdan, FileSerdan>();

            //services.AddAutoMapper();
            //services.AddAutoMapper(NPC, NpcMagic, NpcPower, NpcStat, 
            //    CreateNPCstep1Model, CreateNPCstep2Model, 
            //    CreateNPCstep3Model, CreateNPCstep4Model);

            return services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.ApplicationName==Environments.Development)
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePages();

            //app.UseReact(config => { });

           // app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            
            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseMvc();
            //app.UseMvc(RouteOptions);
            //app.UseMvc();

        }

        private void RouteOptions(IRouteBuilder routes)
        {
            routes.MapRoute("Talang", "api/{controller=Talent}/{id}");
            routes.MapRoute("Default", "{controller=Home}/{action=Index}");
        }
    }
}
