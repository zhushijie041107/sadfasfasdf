using BD.Tms.IRespository;
using BD.Tms.IServices;


namespace BD.Tms.Services
{
    public class BaseServices<T> : IBaseServices<T> where T : class
    {
        private readonly IBaseRespositry<T> _iBaseRespositry;

        public BaseServices(IBaseRespositry<T> iBaseRespositry)
        {
            _iBaseRespositry = iBaseRespositry;
        }

        public void Add(T entity)
        {
            _iBaseRespositry.Add(entity);
        }

        public void Delete(T entity)
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

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
