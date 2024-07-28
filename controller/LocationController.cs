using BarberSchedules.Models;
using BarberSchedules.Services;
using BarberSchedules.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BarberSchedules.Controller
{
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {

        ILocationInterface _locationInterface;
        public LocationController(ILocationInterface locationInterface)
        {
            _locationInterface = locationInterface;
        }

        [HttpGet("getLocation")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _locationInterface.GetLocation());
        }

        [HttpGet("getLocationById/{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] int id)
        {
            return Ok(await _locationInterface.GetById(id));
        }

        [HttpPost("createLocation")]
        public async Task<IActionResult> CreateUser([FromBody] LocationModel location)
        {
            return Ok(await _locationInterface.CreateLocation(location));
        }

        [HttpPatch("updateLocation")]
        public async Task<IActionResult> UpdateUser([FromBody] LocationModel location)
        {
            return Ok(await _locationInterface.UpdateById(location));
        }

        [HttpDelete("deleteLocation")]
        public async Task<IActionResult> DeleteUser([FromBody] int userId)
        {
            return Ok(await _locationInterface.DeleteById(userId));
        }
    }
}