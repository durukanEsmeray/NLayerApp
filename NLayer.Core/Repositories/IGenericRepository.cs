using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    //repository design patterns uygulanması için --> kod ve veritabanı arasına bir katman yerleştirir ve bu katman sayesinde veri tabanına yapılacak temek crud operasyonlarını kolay bir şekilde her bir entity için uygulayabilmemize imkan verir.
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id); // Task<T>, C# programlama dilinde asenkron işlemleri temsil eden bir sınıftır. T, Task<T> türündeki nesnenin tamamlanması durumunda döndüreceği değeri temsil eder.

        // Task<T> sınıfı, bir metodu veya işlemi asenkron olarak çalıştırırken, sonucun tamamlandığında bir değer döndürmek için kullanılır. Örneğin, bir web API çağrısının sonucunu asenkron olarak beklerken Task<T> kullanabilirsiniz. Task<T>, metot tamamlandığında ilgili değeri elde etmenizi sağlar.
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);    // veri tabanına yapılacak olan sorguyu oluşturuyorun.
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
