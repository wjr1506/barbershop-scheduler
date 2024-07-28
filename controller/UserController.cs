using BarberSchedules.Models;
using BarberSchedules.Services;
using BarberSchedules.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BarberSchedules.Controller
{
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        IUserInterface _userInterface;
        public UserController(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userInterface.GetUsers());
        }

        [HttpGet("getUserById")]
        public async Task<IActionResult> GetUserById([FromBody] int userId)
        {
            return Ok(await _userInterface.GetById(userId));
        }

        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserModel userModel)
        {
            return Ok(await _userInterface.CreateUser(userModel));
        }

        [HttpPatch("updateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UserModel userModel)
        {
            return Ok(await _userInterface.UpdateById(userModel));
        }

        [HttpDelete("deleteUser")]
        public async Task<IActionResult> DeleteUser([FromBody] int userId)
        {
            return Ok(await _userInterface.DeleteById(userId));
        }
    }
}