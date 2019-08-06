using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Abac.Api
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

            

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Register");
            });

            services.AddTransient<IAuthorizationHandler, AgeHandler>();

            services.AddAuthorization(opts => {

                opts.AddPolicy("AgeLimit",
                    policy => policy.Requirements.Add(new AgeRequirement(18)));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AtLeast21", policy =>
            //        policy.Requirements.Add(new Atleast21Requirement() { Age = 22 }));
            //});


            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AtLeast21", policy =>
            //        policy.Requirements.Add(new MinimumAgeRequirement(21)));
            //});


            //services.AddMvc(obj =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //    obj.Filters.Add(new AuthorizeFilter(policy));
            //}).SetCompatibilityVersion(CompatibilityVersion.Version_2_2); ;

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("RequireManagerOnly", policy =>
            //           policy.RequireRole("Manager"));
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
