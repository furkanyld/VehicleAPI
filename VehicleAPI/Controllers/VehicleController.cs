using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Models;
using VehicleAPI.Services;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _repository;
        public VehicleController(IVehicleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("SelectCarsByColor/{color}")]
        public async Task<IActionResult> SelectCarsByColor(string color)
        {
            var selectedCars = await _repository.SelectCarsByColor(color);
            return Ok(selectedCars);
        }

        [HttpGet("SelectBusesByColor/{color}")]
        public async Task<IActionResult> SelectBusesByColor(string color)
        {
            var selectedBuses = await _repository.SelectBusesByColor(color);
            return Ok(selectedBuses);
        }

        [HttpGet("SelectBoatsByColor/{color}")]
        public async Task<IActionResult> SelectBoatsByColor(string color)
        {
            var selectedBoats = await _repository.SelectBoatsByColor(color);
            return Ok(selectedBoats);
        }

        [HttpGet("GetCarById/{id}")]
        public async Task<ActionResult<Car>> GetCarById(int id)
        {
            var car = await _repository.GetCarById(id);
            return Ok(car);
        }

        [HttpPut("TurnHeadlights/{id}")]
        public async Task<ActionResult<Car>> TurnHeadlights(int id, bool state)
        {
            var car = await _repository.TurnHeadlights(id, state);
            return Ok(car);
        }

        [HttpDelete("DeleteCar/{id}")]
        public IActionResult DeleteCar(int id)
        {
             _repository.DeleteCar(id);
             return NoContent();
        }
    }
}
