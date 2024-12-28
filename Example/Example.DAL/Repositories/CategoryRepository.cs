using Example.Core.Entities;
using Example.Core.Repositories;
using Example.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ExampleDbContext context) : base(context)
    {
    }
}
