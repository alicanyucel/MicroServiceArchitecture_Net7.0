using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Domain.Service;

namespace User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;
        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        [HttpGet]
        [Route("getusername")]
        public ActionResult Get(string username)
        {
            var dto = UserService.GetUserByUsername(username);
            return Ok(dto);
        }
    }
}
