using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;
using CarShowroom.Database;
using CarShowroom.Domain;
using CarShowroom.Domain.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace CarShowroom.API
{
    public class Startup
    {
        public  IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
//            services.AddCors(options =>
//            {
//                options.AddPolicy("CorsPolicy", builder =>
//                {
//                    builder.WithOrigins("http://localhost:9004",
//                            "http://127.0.0.1:9004",
//                            "http://localhost:9005",
//                            "http://127.0.0.1:9005");
//                        //.AllowAnyHeader()
//                        //.AllowAnyMethod()
//                        //.AllowCredentials();
//                });
//            });
            
            services.AddEntityFrameworkNpgsql().AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("CarShowroom.API")));
           
            #region AutoMapper

            services.AddAutoMapper(config => 
                Mapper.Initialize(b =>
                {
                    b.AddProfile(typeof(MappingProfile));
                    
                }));

            #endregion

            services.AddDomain();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                    {Title = "CarShowroom", Version = "v1"});
                
//                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
//                c.IncludeXmlComments(xmlPath);
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();
            //app.UseCors();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarShowroom"); });

            app.UseMvc();
        }
    }
}