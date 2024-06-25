namespace BD.Tms.IServices
{
    public interface IBaseServices<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(string Id);
        void DeleteAll(string[] Ids);
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetPageList(int pageIndex, int pageSize, out int totalCount);
        
    }
}
