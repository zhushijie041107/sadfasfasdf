using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD.Tms.Domain;
using BD.Tms.IRespository;

namespace BD.Tms.ResporityAdo
{
    public class UserRespority: IUserRespositry
    {
        DbHelper db = new DbHelper();
        #region todo...
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll(string[] Ids)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetPageList(int pageIndex, int pageSize, out int totalCount)
        {
            throw new NotImplementedException();
        }

        

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        public User Login(string userName, string passWord)
        {
            string sql = $"select * from [User] where UserName='{userName}' and PassWord='{passWord}'";

            var user = db.ExecuteDataTable(sql);
            User userObj = new User();
            userObj.Id = user.Rows[0]["Id"].ToString();
            userObj.UserName = user.Rows[0]["UserName"].ToString();
            return userObj;
        }
    }
}
