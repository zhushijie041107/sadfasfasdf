using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.Tms.Domain;

namespace BD.Tms.IServices.UserInfo
{
    public interface IUserServices : IBaseServices<User>
    {
        ApiResult Login(RequestLoginDto requestLoginDto);
    }
}
