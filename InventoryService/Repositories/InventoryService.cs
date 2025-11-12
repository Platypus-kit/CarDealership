using InventoryService.Data;
using InventoryService.Domain.Entities;
using InventoryService.Domain.Enums;
using InventoryService.Domain.ValueObjects;
using InventoryService.DTO.Request;
using InventoryService.DTO.Response;
using InventoryService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Repositories
{
    public class InventoryService : IInventoryService
    {
        private readonly AppDbContext _context;
        public InventoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AvailableResponse?> AvailableAsync()
        {
            return new AvailableResponse(await _context.CarInventories.Where(status => status.Position.OrderStatus == OrderStatus.Available).ToListAsync());
        }

        public async Task<CarInformationResponse?> InformationAsync(CarInformationRequest carInformationRequest)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Id == carInformationRequest.CarId);
            if (car == null) 
                throw new ArgumentNullException(nameof(car));
            return new CarInformationResponse(car);
        }

        public async Task<CarMarkSoldResponse?> MarkSoldAsync(CarMarkSoldRequest carMarkSoldRequest)
        {
            var carInvent = await _context.CarInventories.FirstOrDefaultAsync(carInv => carInv.CarId == carMarkSoldRequest.CarId);
            if (carInvent is null)
                throw new ArgumentNullException(nameof(carInvent));
            return new CarMarkSoldResponse(carInvent.Indicator, carInvent.Position, carInvent.ZoneTime);
        }


        public async Task<List<CarReleaseResponse>> ReleaseAsync(CarReleaseRequest carReleaseRequest)
        {
            var carInventList = await _context.CarInventories.Where(c => c.ZoneTime.CreatedAt == carReleaseRequest.Time.CreatedAt).ToListAsync();
            return carInventList.Select(inventory => new CarReleaseResponse(
                Indicator: inventory.Indicator,
                Position: inventory.Position,
                Time: carReleaseRequest.Time
            )).ToList();
            
        }

        public async Task<CarReserveResponse> ReserveAsync(CarReserveRequest carReserveRequest)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Id == carReserveRequest.CarId);
            if (car is null)
                throw new ArgumentNullException(nameof(car));
            var reserveCar = await _context.CarInventories.FirstOrDefaultAsync(carInv => carInv.CarId == car.Id);
            if (reserveCar is null)
                throw new ArgumentNullException(nameof(reserveCar));
            reserveCar.Position.OrderStatus = OrderStatus.Reserve;
            await _context.SaveChangesAsync();
            return new CarReserveResponse(car);
        }
    }
}