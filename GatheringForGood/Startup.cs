using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using GatheringForGood.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Localization;
using GatheringForGood.LocalizationResources;
using GatheringForGood.Models;
using Microsoft.Extensions.Options;
using Microsoft.CodeAnalysis.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using GatheringForGood.Areas.FunctionalLogic;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace GatheringForGood
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<ApplicationUser>(options => { options.SignIn.RequireConfirmedAccount = true; }).AddEntityFrameworkStores<ApplicationDbContext>();
            // requires
            // using Microsoft.AspNetCore.Identity.UI.Services;
            // using WebPWrecover.Services;
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);
            services.Configure<AuthStripeOptions>(Configuration);
            //services.AddControllersWithViews();
            //services.AddRazorPages();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMemoryCache();

            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
            });
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.User.RequireUniqueEmail = true;
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
                options.Lockout.MaxFailedAccessAttempts = 3;
            });

            services.AddHsts(options =>
            {
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(365);
            });

            var cultures = new[]
            {
                new CultureInfo("de"),
                new CultureInfo("en"),
            };

            services.AddMvc()
    .AddExpressLocalization<LocSource>(ops =>
    {
        ops.UseAllCultureProviders = false;
        ops.ResourcesPath = "LocalizationResources";
        ops.RequestLocalizationOptions = o =>
        {
            o.SupportedCultures = cultures;
            o.SupportedUICultures = cultures;
            o.DefaultRequestCulture = new RequestCulture("en");
        };
    });
            services.AddSingleton<IValidationAttributeAdapterProvider, MustBeTrueAdapterProvider>();

            /*
            services.AddControllersWithViews()
                .AddExpressLocalization<LocSource>(ops =>
                    {
                        ops.UseAllCultureProviders = false;
                        ops.ResourcesPath = "LocalizationResources";
                        ops.RequestLocalizationOptions = o =>
                        {
                            o.SupportedCultures = cultures;
                            o.SupportedUICultures = cultures;
                            o.DefaultRequestCulture = new RequestCulture("en");
                        };
                    });
            */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                app.Use(async (context, next) =>
                {
                    context.Response.Headers.Add("X-Frame-Options", "DENY");
                    context.Response.Headers.Add("X-Xss-Protection", "1; mode=block");
                    context.Response.Headers.Add("Referrer-Policy", "no-referrer");
                    context.Response.Headers.Add("X-Permitted-Cross-Domain-Policies", "none");
                    context.Response.Headers.Add("Content-Security-Policy", "default-src https:; img-src 'self' blob: data: https://gatheringforgood-nonlive.azurewebsites.net/ https://gatheringforgood.com/ https://www.gatheringforgood.com http://www.w3.org https://www.google-analytics.com https://www.googletagmanager.com https://i.ytimg.com https://syndication.twitter.com https://gatheringforgoodimages.blob.core.windows.net/; script-src https://az416426.vo.msecnd.net https://ajax.aspnetcdn.com https://ajax.googleapis.com https://gatheringforgood-nonlive.azurewebsites.net https://gatheringforgood.com https://www.gatheringforgood.com https://www.google-analytics.com https://www.googletagmanager.com https://unpkg.com https://code.jquery.com https://cdn.jsdelivr.net https://maxcdn.bootstrapcdn.com https://gitcdn.github.io https://platform.twitter.com https://connect.facebook.net 'unsafe-inline'; style-src https://gatheringforgood-nonlive.azurewebsites.net/css/style.css https://gatheringforgood.com/css/style.css https://www.gatheringforgood.com/css/style.css https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css https://localhost:44306 https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css https://cdn.jsdelivr.net/gh/gitbrent/bootstrap4-toggle@3.6.1/css/bootstrap4-toggle.min.css 'unsafe-inline'");
                    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                    await next();
                });
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{culture=en}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Newsfeed",
                    pattern: "{culture=en}/{controller=Newsfeed}/{action=Newsfeed}/{id?}");
                endpoints.MapControllerRoute(
                    name: "About",
                    pattern: "{culture=en}/{controller=About}/{action=About}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Help",
                    pattern: "{culture=en}/{controller=Help}/{action=Help}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Articles",
                    pattern: "{culture=en}/{controller=Articles}/{action=Articles}/{id?}");
                endpoints.MapControllerRoute(
                    name: "UserArticle",
                    pattern: "{culture=en}/{controller=UserArticle}/{action=UserArticle}/{id?}");
                endpoints.MapControllerRoute(
                    name: "OffsetMyCarbon",
                    pattern: "{culture=en}/{controller=OffsetMyCarbon}/{action=OffsetMyCarbon}/{id?}");
                endpoints.MapControllerRoute(
                    name: "CreateArticle",
                    pattern: "{culture=en}/{controller=CreateArticle}/{action=CreateArticle}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Cookies",
                    pattern: "{culture=en}/{controller=Cookies}/{action=Cookies}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Privacy",
                    pattern: "{culture=en}/{controller=Privacy}/{action=Privacy}/{id?}");
                endpoints.MapControllerRoute(
                    name: "ReduceGlobalWarming",
                    pattern: "{culture=en}/{controller=ReduceGlobalWarming}/{action=ReduceGlobalWarming}/{id?}");
                endpoints.MapControllerRoute(
                    name: "ReduceAnimalExtinction",
                    pattern: "{culture=en}/{controller=ReduceAnimalExtinction}/{action=ReduceAnimalExtinction}/{id?}");
                endpoints.MapControllerRoute(
                    name: "ReduceDeforestation",
                    pattern: "{culture=en}/{controller=ReduceDeforestation}/{action=ReduceDeforestation}/{id?}");
                endpoints.MapControllerRoute(
                    name: "TermsAndConditions",
                    pattern: "{culture=en}/{controller=TermsAndConditions}/{action=TermsAndConditions}/{id?}");
                endpoints.MapControllerRoute(
                    name: "UserBadges",
                    pattern: "{culture=en}/{controller=UserBadges}/{action=UserBadges}/{id?}");
                endpoints.MapControllerRoute(
                    name: "CarbonOffsets",
                    pattern: "{culture=en}/{controller=CarbonOffsets}/{action=CarbonOffsets}/{id?}");
                endpoints.MapControllerRoute(
                    name: "OffsetMyCarbon",
                    pattern: "{culture=en}/{controller=OffsetMyCarbon}/{action=OffsetMyCarbon}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Updates",
                    pattern: "{culture=en}/{controller=Updates}/{action=Updates}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
