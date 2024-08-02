using VehicleAPI.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VehicleAPI.VehicleDb;
using VehicleAPI.Data.SeedData;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace VehicleAPI.Services
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleDbContext _context;
        public VehicleRepository(VehicleDbContext context) 
        {
            _context = context;
            
        }
        public async Task DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
        }

        public async Task<Car> GetCarById(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            return car;
        }

        public async Task<Car> TurnHeadlights(int id, bool state)
        {
            var car = await _context.Cars.FindAsync(id);
            car.headlightsOn = state;
            await _context.SaveChangesAsync();
            return car;
        }

        public async Task<IEnumerable<Boat>> SelectBoatsByColor(string color)
        {
            return await _context.Boats
                .Where(bo => bo.Color.ToLower() == color.ToLower())
                .ToListAsync();
        }

        public async Task<IEnumerable<Bus>> SelectBusesByColor(string color)
        {
            return await _context.Buses
                .Where(bu => bu.Color.ToLower() == color.ToLower())
                .ToListAsync();
        }

        public async Task<IEnumerable<Car>> SelectCarsByColor(string color)
        {
            return await _context.Cars
                .Where(c => c.Color.ToLower() == color.ToLower())
                .ToListAsync();
        }
    }
}
