using Example.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Configurations;

public class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
{
    public void Configure(EntityTypeBuilder<ProductTag> builder)
    {
        builder.HasOne(pt => pt.Product)
            .WithMany(p => p.Products)
            .HasForeignKey(pt => pt.ProductId);

        builder.HasOne(pt => pt.Tag)
            .WithMany(t => t.Tags) 
            .HasForeignKey(pt => pt.TagId);

        builder.HasKey(pt => new { pt.ProductId, pt.TagId });

    }
}
