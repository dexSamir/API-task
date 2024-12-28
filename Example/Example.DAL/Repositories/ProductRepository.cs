using Example.Core.Entities;
using Example.Core.Repositories;
using Example.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ExampleDbContext context) : base(context)
    {
    }
}
