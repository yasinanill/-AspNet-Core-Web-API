using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public  interface IGenericRepository<T> where T : class
    {

        Task<T>   GetByIdAsync(int id);

        IQueryable<T> Where(Expression<Func<T, bool>> expression);  // list kullanmamamizin sebebi direk olarak ver' tabani baglantisi yapmamasi ve performans acisindan faydasi
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);  
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync (T entity);
        void Update (T entity);
        void Delete (T entity);

        Task AddRangeAsync(IEnumerable<T> entities );
        Task RemoveRangeAsync(IEnumerable<T> entities );

    }
}
