using BD.Tms.IServices.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.Tms.Domain;
using BD.Tms.IRespository;


namespace BD.Tms.Services
{
    public class UserServices : BaseServices<User>, IUserServices
    {
        private readonly IUserRespositry _userRespositry;

        public UserServices(IUserRespositry userRespositry) : base(userRespositry)
        {
            _userRespositry = userRespositry;
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="requestLoginDto"></param>
        /// <returns></returns>
        public ApiResult Login(RequestLoginDto requestLoginDto)
        {
            var user = _userRespositry.Login(requestLoginDto.UserName, requestLoginDto.Password);
            ResponseLoginDto responseLoginDto = new ResponseLoginDto();
            if (user != null)
            {
                responseLoginDto.Id = user.Id;
                responseLoginDto.UserName = user.UserName;
                responseLoginDto.Phone = user.Phone;
                responseLoginDto.Email = user.Email;
                return new ApiResult() { Code = 200, Msg = "登录成功", Data = responseLoginDto };
            }
            //return new ApiResult().Success(responseLoginDto);
            return new ApiResult() { Code = 500, Msg = "登录失败" };
        }
    }
}
