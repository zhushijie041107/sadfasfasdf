using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BD.Tms.IRespository;

namespace BD.Tms.Respository
{
    public class BaseRespositry<T> : IBaseRespositry<T> where T : class
    {
        private readonly TmsDbContext _tmsDbContext;

        public BaseRespositry(TmsDbContext tmsDbContext)
        {
            _tmsDbContext = tmsDbContext;
        }
        public void Add(T entity)
        {
            _tmsDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _tmsDbContext.Set<T>().Remove(entity);
            
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll(string[] Ids)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetPageList(int pageIndex, int pageSize, out int totalCount)
        {
            
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _tmsDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
