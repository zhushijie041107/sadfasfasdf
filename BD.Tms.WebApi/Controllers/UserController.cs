using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BD.Tms.IServices.UserInfo;

namespace BD.Tms.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;

        public UserController(IUserServices userService)
        {
            _userService = userService;
        }
        [HttpPost("login")]
        public IActionResult Login(RequestLoginDto requestLoginDto)
        {
            //不要相信前端传过来的任何数据（做参数验证）
            if (requestLoginDto == null)
            { 
                return BadRequest("请求参数不能为空");//400
            }
            if (string.IsNullOrEmpty(requestLoginDto.UserName) || string.IsNullOrEmpty(requestLoginDto.Password))
            {
                return BadRequest("用户名或密码不能为空");//400
            }

            var result = _userService.Login(requestLoginDto);
            return Ok(result);
        }
    }

  
}
