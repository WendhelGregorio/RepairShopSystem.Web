using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectBSIS401.WEB.Areas.Manage.ViewModels.hub;
using ProjectBSIS401.WEB.Infrastructures.Domain.Data;
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;

namespace ProjectBSIS401.WEB
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

             services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(options =>
            {
                options.Cookie.Expiration = TimeSpan.FromDays(1);
                options.Cookie.MaxAge = TimeSpan.FromDays(1);
                options.Cookie.Name = "ProjectBSIS401";
            });

            //SignarR Authorization
            services.AddSignalR();

            services.AddDbContext<DefaultDbContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultDbContextMySQL"), m => m.MigrationsAssembly("ProjectBSIS401.WEB")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IAuthorizationHandler, AuthorizeAdminRequirementHandler>();
            services.AddScoped<IAuthorizationHandler, AuthorizeContentAdminRequirementHandler>();


            services.AddAuthorization(options =>
            {
                options.AddPolicy("SignedIn", policy => policy.RequireAuthenticatedUser());
                options.AddPolicy("AuthorizeAdmin", policy => policy.Requirements.Add(new AuthorizeAdminRequirement()));
                options.AddPolicy("AuthorizeContentAdmin", policy => policy.Requirements.Add(new AuthorizeContentAdminRequirement()));
            });

            services.AddSession(options =>  
            {
                options.IdleTimeout = TimeSpan.FromDays(1);
            });

            //this services convert enums to return string result.
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                
            });



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }


        //Middleware Pipeline
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            
            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chathub");
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();
            Infrastructures.Domain.Helper.WebUser.Services = app.ApplicationServices;
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
