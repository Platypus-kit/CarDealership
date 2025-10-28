using CatalogService.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purchase_Service.Domain.Entities;
using Purchase_Service.Domain;

namespace CatalogService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<OrderDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.MapGet("/purchase", async (OrderDbContext db) => await db.Purchases.ToListAsync());

            app.MapPost("/purchase", async (Purchase purchase, OrderDbContext db) =>
            {
                db.Purchases.Add(purchase);
                await db.SaveChangesAsync();
                return Results.Created($"//{purchase.Id}", purchase);
            });

            app.MapPut("/purchase/{id}", async (Guid id, [FromBody] PurchaseRequest purchaseRequest, OrderDbContext db) =>
            {
                Purchase? purchase = db.Purchases.FirstOrDefault(purchase => purchase.Id == id);
                if (purchase is null)
                {
                    return Results.BadRequest("customer not found");
                }
                purchase.PurchaseStatus = purchaseRequest.PurchaseStatus;
                purchase.CarReserve = purchaseRequest.CarReserve;
                purchase.CustomerVerification = purchaseRequest.CustomerVerification;
                purchase.ExecutionOfTheTransactionarReserve = purchaseRequest.ExecutionOfTheTransactionarReserve;
                purchase.Payment = purchaseRequest.Payment;
                db.Purchases.Update(purchase);
                await db.SaveChangesAsync();
                return Results.Created($"/purchase/{purchase.Id}", purchase);
            });

            app.MapDelete("/purchase/{id}", async (Guid id, OrderDbContext db) =>
            {
                Purchase? purchase = await db.Purchases.FirstOrDefaultAsync(order => order.Id == id);
                if (purchase is null)
                {
                    throw new ArgumentNullException("purchase not found");
                }
                db.Purchases.Remove(purchase);
                await db.SaveChangesAsync();
                return Results.Created($"/purchase/ {purchase.Id}", purchase);
            });

            app.UseHttpsRedirection();
            app.Run();
        }
    }
}