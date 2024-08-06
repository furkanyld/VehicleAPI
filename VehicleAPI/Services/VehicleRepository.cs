using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleAPI.Models;
using VehicleAPI.VehicleDb;

namespace VehicleAPI.Services
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleDbContext _context;

        public VehicleRepository(VehicleDbContext context) 
        {
            _context = context;
            
        }

        public async Task<Car> CreateCar(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return car;
        }

        public async Task<Car> DeleteCar(int id)
        {
             var car = await _context.Cars.FindAsync(id);

             if (car == null)
             {
                throw new Exception();
             }

             _context.Cars.Remove(car);
             await _context.SaveChangesAsync();
            return car;
        }

        public async Task<Car> GetCarById(int id)
        {
            var car = await _context.Cars.FindAsync(id);

            if(car is null)
            {
                return null;
            }

            return car;
        }

        public async Task<Car> TurnHeadlights(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            
            if (car is null)
            {
                return null;
            }
            if (car.HeadlightsOn == true)
            {
                car.HeadlightsOn = false;
            }
            else
            {
                car.HeadlightsOn = true;
            }
            await _context.SaveChangesAsync();
            return car;
        }

        public async Task<IEnumerable<Boat>> SelectBoatsByColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                return new List<Boat>();
            }

            return await _context.Boats
                 .Where(bo => bo.Color.ToLower() == color.ToLower())
                 .ToListAsync();
        }

        public async Task<IEnumerable<Bus>> SelectBusesByColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                return new List<Bus>();
            }
            return await _context.Buses
                .Where(bu => bu.Color.ToLower() == color.ToLower())
                .ToListAsync();
        }

        public async Task<IEnumerable<Car>> SelectCarsByColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color))
            {
                return new List<Car>();
            }
            return await _context.Cars
                .Where(c => c.Color.Contains(color))
                .ToListAsync();
        }
    }
}
