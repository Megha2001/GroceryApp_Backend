using GroceryApp.Models;
using GroceryApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public IActionResult Post(Users user)
        {
            var data = userService.RegisterUser(user);
            return Ok(data);
        }

        [HttpGet]
        public IActionResult Get(string email, string password)
        {
            var data = userService.LoginUser(email, password);
            if (data == null)
                return NotFound();
            return Ok(data);
        }
    }
}
