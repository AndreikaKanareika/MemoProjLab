using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation.AspNetCore;
using FluentValidation.WebApi;
using Lab.Filters;
using Lab.SeedData;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Microsoft.VisualStudio.Services.WebApi.Jwt;
using TeacherMemo.Identity.Entities;
using TeacherMemo.Persistence.Abstact;
using TeacherMemo.Persistence.Abstact.Entities;
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
           // services.AddHttpContextAccessor();
           // services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

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

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMemoService, MemoService>();
            services.AddTransient<ISubjectService, SubjectService>();
            services.AddTransient<IMemoRepository, MemoRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddDbContext<MemoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); // TODO: change conn string in config

            services.AddTransient<IUserStore<UserEntity>, UserRepository>();
            services.AddIdentity<UserEntity, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<MemoContext>();

            services.AddScoped<IDbSeeder, DbSeeder>();

            Mapper.Initialize(cfg => cfg.AddProfiles(GetType().Assembly));

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = AuthOptions.ISSUER,

                        ValidateAudience = true,
                        ValidAudience = AuthOptions.AUDIENCE,

                        ValidateLifetime = true,

                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                        ValidateIssuerSigningKey = true
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = async context =>
                        {
                            var userManager = (UserManager<UserEntity>)context.HttpContext.RequestServices.GetService(typeof(UserManager<UserEntity>));
                            var user = await userManager.FindByIdAsync(context.Principal.Claims.First(c => c.Type == "userId").Value);

                            if (user == null)
                            {
                                context.Fail(new InvalidTokenException($"User { context.Principal.Identity.Name } does not exist"));
                                return;
                            }

                            var claim = new[]
                            {
                                new Claim("userId", user.Id.ToString()),
                                new Claim("role", user.Role)
                            };
                            context.Principal.AddIdentity(new ClaimsIdentity(claim));
                        }
                    };
                });


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


                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });
            });

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // some changes :)
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
            app.UseAuthentication();
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
