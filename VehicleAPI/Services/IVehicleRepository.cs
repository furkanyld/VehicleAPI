using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Models;

namespace VehicleAPI.Services
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Car>> SelectCarsByColor(string color);
        Task<IEnumerable<Bus>> SelectBusesByColor(string color);
        Task<IEnumerable<Boat>> SelectBoatsByColor(string color);
        Task<Car> GetCarById(int id);
        Task<Car> TurnHeadlights(int id);
        Task<Car> DeleteCar(int id);
    }
}
