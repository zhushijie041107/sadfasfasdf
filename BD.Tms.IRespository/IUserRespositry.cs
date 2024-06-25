using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.Tms.Domain;

namespace BD.Tms.IRespository
{
    public interface IUserRespositry: IBaseRespositry<User>
    {
        User Login(string userName, string passWord);
    }
}
