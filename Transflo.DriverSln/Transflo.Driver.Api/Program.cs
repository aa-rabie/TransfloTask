
using Microsoft.EntityFrameworkCore;
using Transflo.Driver.Data;
using Transflo.Driver.Application;
using FluentValidation;
using Transflo.Driver.Api.Endpoints;
using Microsoft.Extensions.Hosting;

namespace Transflo.DriverApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services
            .RegisterApplicationServices()
            .RegisterDataServices(builder.Configuration)
            .AddValidatorsFromAssemblyContaining<Program>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.MapDriverEndpoints();
        app.MapAlphabetizerEndpoints();

        EnsureDbInitialized(app);

        app.Run();
    }

    private static void EnsureDbInitialized(WebApplication app) {
        //ensure in development environment that EF migrations are executed and Db is updated
        if (app.Environment.IsDevelopment())
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DriverDbContext>();
                db.Database.Migrate();
            }
        }
    }
}
