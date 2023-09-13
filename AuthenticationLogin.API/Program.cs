using AuthenticationLogin.Core.Domain.Applications.Interfaces;
using AuthenticationLogin.Core.Domain.Dtos.JWT;
using AuthenticationLogin.Infraestructure.Utils;
using System.Net;

namespace AuthenticationLogin.API {
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
         
            builder.Services.Configure<JWTConfiguration>(builder.Configuration.GetSection("JWTConfiguration"));
            // Add services to the container.
            builder.Services.AddApplication();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHsts();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
               
               
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}