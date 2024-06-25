using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.Tms.Domain;
using BD.Tms.IRespository;

namespace BD.Tms.Respository
{
    public class UserRespositry : BaseRespositry<User>, IUserRespositry
    {
        private readonly TmsDbContext _tmsDbContext;
        public UserRespositry(TmsDbContext tmsDbContext) : base(tmsDbContext)
        {
            _tmsDbContext = tmsDbContext;
        }

        public User Login(string userName, string passWord)
        {
            
            var item =  _tmsDbContext.Users.FirstOrDefault(u => u.UserName == userName); //返回null
          
            if (item == null)
            {
                return null;
            }
            if (item.Password == passWord)
            {
                return item;
            }
            return null;
        }
    }
}
