using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataAccess.Repository;
using HCLSWebAPI.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCLSWebAPI
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
            services.AddCors();
            services.AddSwaggerGen();
            services.AddControllers();
            services.AddDbContext<DBContextt>(options => options.UseSqlServer(Configuration.GetConnectionString("Constr")));
            services.AddTransient<IAdmintypeRepo,AdminTypeRepo>();
            services.AddTransient<IAdminRepo,AdminRepo>();
            services.AddTransient<IDeptRepo,DeptRepo>();
            services.AddTransient<IReceptionRepo,ReceptionRepo>();
            services.AddTransient<IHelperRepo,HelperRepo>();
            services.AddTransient<ILabRepo,LabRepo>();
            services.AddTransient<IDocSpecRepo, DocSpecRepo>();
            services.AddTransient<IDocRepo,DocRepo>();
            services.AddTransient<IPatientStatusRepo,PatientStatusRepo>();
            services.AddTransient<IPatientRepo,PatientRepo>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        
                app.UseCors(builder =>
                            {
                            builder
                           .AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();

                           });


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HCLSProject");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
