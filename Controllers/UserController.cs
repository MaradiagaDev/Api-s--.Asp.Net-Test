using ASP.Net_Test.Models;
using ASP.Net_Test.Objects;
using ASP.Net_Test.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;
        public UserController(IUserService userService) {
            this.UserService = userService;
        }
        [HttpGet]
        [Route("GetUser/all")]
        public IActionResult GetAll() 
        {
         IEnumerable<User> user = UserService.GetAll();
         return Ok(user);
        }
        [HttpPost]
        [Route("CreateUser")]
        public IActionResult CreateUser(UserModel user)
        {
            this.UserService.CreateUser(user);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/User")]
        public IActionResult DeleteUser(int id)
        {
            this.UserService.Delete(id);
            return Ok();
        }
    }
}
