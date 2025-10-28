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
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.MapGet("/orders", async (AppDbContext db) => await db.Orders.ToListAsync());

            app.MapPost("/orders", async (Order order, AppDbContext db) =>
            {
                db.Orders.Add(order);
                await db.SaveChangesAsync();
                return Results.Created($"/orders/{order.Id}", order);
            });

            app.MapPut("/orders/{id}", async (Guid id, [FromBody] bool isCompleted, AppDbContext db) =>
            {
                Order? order = db.Orders.FirstOrDefault(order => order.Id == id);
                order.IsCompleted = isCompleted;
                db.Orders.Update(order);
                await db.SaveChangesAsync();
                return Results.Created($"/orders/{order.Id}", order);
            });

            app.MapDelete("/orders/{id}", async (Guid id, AppDbContext db) =>
            {
                Order? order = await db.Orders.FirstOrDefaultAsync(order => order.Id == id);
                if (order is null)
                {
                    throw new ArgumentNullException("order not found");
                }
                db.Orders.Remove(order);
                await db.SaveChangesAsync();
                return Results.Created($"/orders/{order.Id}", order);
            });

            app.UseHttpsRedirection();
            app.Run();
        }
    }
}
