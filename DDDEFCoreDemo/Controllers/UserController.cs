using Infrastructure.Model;
using Infrastructure.Repository.Users;
using Microsoft.AspNetCore.Mvc;

namespace DDDEFCoreDemo.Controllers
{
    [Route("api/")]
    [ApiController]
    public class UserController : Controller
    {
        IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //查找表中所有数据
        [HttpGet("user/getall")]
        public IActionResult GetAll()
        {
            List<User> UserTable = _userRepository.GetAllUser();  //查出所有
            return Ok(UserTable);
        }
    }
}
