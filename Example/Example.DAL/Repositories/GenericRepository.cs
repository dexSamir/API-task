using Example.Core.Entities.Common;
using Example.Core.Repositories;
using Example.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Repositories;

public class GenericRepository<T> : IGenericRepository<T>
    where T : BaseEntity, new()
{
    readonly ExampleDbContext _context;
    protected DbSet<T> Table => _context.Set<T>();
    public GenericRepository(ExampleDbContext context)
    {
        _context = context;
    }
    
    public async Task AddAsync(T entity)
        => await Table.AddAsync(entity);

    public Task AddRangeAsync(params T[] entities)
        => Table.AddRangeAsync(entities);

    public async Task<T?> FindByIdAsync(int id)
        => await Table.FindAsync(id);

    public IQueryable<T> GetAll()
        => Table.AsQueryable();

    public IQueryable<T> GetWhere(Func<T, bool> expression)
        => Table.Where(expression).AsQueryable(); 

    public async Task<bool> IsExistsAsync(int id)
        => await Table.AnyAsync(x=> x.Id == id);  

    public void Remove(T entity)
    {
        Table.Remove(entity);   
    }

    public async Task<bool> RemoveAsync(int id)
    {
        int result = await Table.Where(x => x.Id == id).ExecuteDeleteAsync();
        return result > 0;
    }

    public async Task<int> SaveAysnc()
        => await _context.SaveChangesAsync(); 
}
