﻿using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public  interface IGenericRepository<T> where T : class
    {


  
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);  // list kullanmamamizin sebebi direk olarak ver' tabani baglantisi yapmamasi ve performans acisindan faydasi
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
