using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OutilEnquete.Models;
using OPS.DAL;
using Microsoft.Owin.Security.Cookies;


namespace OutilEnquete
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            // Add framework services
            // Configure the db context, user manager and signin manager to use a single instance per request
          
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddDefaultTokenProviders();

            services.AddMvcCore();
            services.AddAuthentication("CookieAuthentication")
                 .AddCookie("CookieAuthentication", config =>
                 {
                     config.Cookie.Name = "UserLoginCookie";
                     config.LoginPath = "/Login/UserLogin";
                 });



            // Add application services.
            //  services.AddTransient<IEmailSender, AuthMessageSender>();
            //services.AddTransient<ISmsSender, AuthMessageSender>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //ILoggingBuilder loggingBuilder = loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();
            app.UseOwin();

            app.UseAuthentication();
            app.UseAuthentication();
            //app.UseEndpoints(routes =>
            //{
            //    Microsoft.AspNetCore.Routing.IRouteBuilder routeBuilder = routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});


            // To configure external authentication please see http://go.microsoft.com/fwlink/?LinkID=532715

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
