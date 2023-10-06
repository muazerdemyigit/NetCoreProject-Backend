﻿using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
