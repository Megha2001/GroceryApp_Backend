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

        [HttpPost("register")]
        public IActionResult Post(Users user)
        {
            user.CreatedDate =  DateTime.Now;

            var data = userService.RegisterUser(user);
            if (data != null)
            {
                return Ok(data);
            }
            else
                return BadRequest(new
                {
                    status = "fail",
                    message = "User already exists",
                    //    token = "your-auth-token",  Replace with the actual token
                          });
        }

        [HttpPost("login")]
        public IActionResult Post(Login user)
        {
            
            Users data = userService.LoginUser(user.Email,user.Password);

            if (data == null)
            {
                return BadRequest(new
                {
                    status = "error",
                    message = "Invalid email or password"
                });
            }
           
            return Ok(new
            {
                status = "success",
                message = "Login successful",  
                user = data
                
            });
        }
    }
}
