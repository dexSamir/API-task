using Example.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Context;

public class ExampleDbContext : DbContext
{
    public ExampleDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Product> Products { get; set; }    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ProductTag> ProductTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExampleDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
