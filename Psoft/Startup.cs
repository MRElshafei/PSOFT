using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Psoft.Application.Manage_BOQ;
using Psoft.Application.Manage_Projects;
using Psoft.Application.Manage_Users;
using Psoft.Data;
using Rotativa.AspNetCore;

namespace Psoft
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
            services.AddHttpClient();
            services.AddDbContextPool<PsoftDBContext>(option =>
          option.UseSqlServer(Configuration.GetConnectionString("PsoftDataBase")));
            services.AddScoped<IManageUsers, ManageUsers>();
            services.AddScoped<IManageProject, ManageProject>();
            services.AddScoped<IManageBOQ, ManageBOQ>();

            services.AddScoped<IManageProjects, ManageProjects>();
            services.AddAuthorization();

            services.AddIdentity<IdentityUser, IdentityRole>
                 (options => {
                 options.SignIn.RequireConfirmedAccount = false;
                 options.User.RequireUniqueEmail = true;
                 })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                 .AddDefaultUI().AddDefaultTokenProviders();

            services.AddRazorPages();
            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/Home", "");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            CreateRoles(serviceProvider).Wait();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            RotativaConfiguration.Setup(env.WebRootPath, "rotativa");

        }

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //initializing custom roles 
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            //var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roleNames = { "Owner", "Contractor" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                // ensure that the role does not exist
                if (!roleExist)
                {
                    //create the roles and seed them to the database: 
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
