
using CatalogService.Data;
using CatalogService.Entityes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));
            var app = builder.Build();
            app.MapGet("/cars", async (AppDbContext db) => await db.Cars.ToListAsync());
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }
            //mapGet(по id) / mapPost(пример прислали) / mapPut(обновить gfhfvtnh по id) / mapDelete(по id)
            
            app.MapPost("/cars", async (Car car, AppDbContext db) =>
            {
                db.Cars.Add(car);
                await db.SaveChangesAsync();
                return Results.Created($"/cars/{car.Id}", car);
            });

            app.MapPut("/cars/{id}", async (Guid id, [FromBody] string model, AppDbContext db) =>
            {
                Car? car = db.Cars.FirstOrDefault(car => car.Id == id);
                car.Model = model;
                db.Cars.Update(car); //Add(car);
                await db.SaveChangesAsync();
                return Results.Created($"/cars/{car.Id}", car);
            });

            app.MapDelete("/cars/{id}", async (Guid id, AppDbContext db) =>
            {
                Car? car = db.Cars.FirstOrDefault(car => car.Id == id);
                if (car is null)
                {
                    throw new ArgumentNullException("car not found");
                }
                db.Cars.Remove(car);
                await db.SaveChangesAsync();
                return Results.Created($"/cars/{car.Id}", car);
            });

            app.UseHttpsRedirection();
            app.Run();
        }
    }
}
