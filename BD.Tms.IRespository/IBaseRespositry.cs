﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Tms.IRespository
{
    public interface IBaseRespositry<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(string Id);
        void DeleteAll(string[] Ids);
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetPageList(int pageIndex, int pageSize, out int totalCount);
        int SaveChanges();
    }
}
