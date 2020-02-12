using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation.AspNetCore;
using FluentValidation.WebApi;
using Lab.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using TeacherMemo.Persistence.Abstact;
using TeacherMemo.Persistence.Implementation;
using TeacherMemo.Services.Abstract;
using TeacherMemo.Services.Implementation;

namespace Lab
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
            services.AddControllers(cfg =>
            {
                cfg.Filters.Add<GlobalExceptionFilter>();
                cfg.Filters.Add<ValidateModelAttribute>();
            })
            .AddNewtonsoftJson()
            .AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssembly(GetType().Assembly));

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddTransient<IMemoService, MemoService>();
            services.AddTransient<IMemoRepository, MemoRepository>();
            services.AddDbContext<MemoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); // TODO: change conn string in config

            Mapper.Initialize(cfg => cfg.AddProfiles(GetType().Assembly));

            services.AddSwaggerGen(c =>
            {
                c.DescribeAllEnumsAsStrings();
                
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Test API"
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            });
        }
    }
}
