using Example.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Core.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new() 
{
    IQueryable<T> GetAll();
    Task<T?> FindByIdAsync(int id);
    IQueryable<T> GetWhere(Func<T, bool> expression);
    Task<bool> IsExistsAsync(int id); 
    Task AddAsync(T entity);
    Task AddRangeAsync(params T[] entities); 
    void Remove(T entity);
    Task<bool> RemoveAsync(int id);
    Task<int> SaveAysnc(); 

}
