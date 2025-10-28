using CatalogService.Data;
using CustomerService;
using CustomerService.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
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

            app.MapGet("/customers", async (AppDbContext db) => await db.Customers.ToListAsync());

            app.MapPost("/customers", async (Customer customer, AppDbContext db) =>
            {
                db.Customers.Add(customer);
                await db.SaveChangesAsync();
                return Results.Created($"//{customer.Id}", customer);
            });

            app.MapPut("/customers/{id}", async (Guid id, [FromBody] CustomerRequest customerRequest, AppDbContext db) =>
            {
                Customer? customer = db.Customers.FirstOrDefault(customer => customer.Id == id);
                if (customer is null)
                {
                    return Results.BadRequest("customer not found");
                }
                customer.Email = customerRequest.Email;
                customer.Phone = customerRequest.Phone;
                customer.FirstName = customerRequest.FirstName;
                customer.LastName = customerRequest.LastName;
                db.Customers.Update(customer);
                await db.SaveChangesAsync();
                return Results.Created($"/customers/{customer.Id}", customer);
            });

            app.MapDelete("/customers/{id}", async (Guid id, AppDbContext db) =>
            {
                Customer? customer = await db.Customers.FirstOrDefaultAsync(order => order.Id == id);
                if (customer is null)
                {
                    throw new ArgumentNullException("order not found");
                }
                db.Customers.Remove(customer);
                await db.SaveChangesAsync();
                return Results.Created($"/customers/ {customer.Id}", customer);
            });

            app.UseHttpsRedirection();
            app.Run();
        }
    }
}