using FluxoProcesso.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using FluxoProcesso.Infra.IOC;
using Newtonsoft.Json;
using Microsoft.OpenApi.Models;

namespace FluxoProcesso.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddInfrastructure(builder.Configuration);

            builder.Services
                .AddControllers()
                .AddNewtonsoftJson(
                opt =>
                {
                    opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "FluxoProcesso.API",
                    Version = "v1",
                    Contact = new OpenApiContact()
                    {
                        Name = "Jo�oDev",
                        Email = "joaovitorschmidtmartins@gmail.com"
                    }
                });

                var xmlFile = "FluxoProcesso.API.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                x.IncludeXmlComments(xmlPath);
            });

            WebApplication app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }



            app.UseHttpsRedirection();

            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
            );

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}