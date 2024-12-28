using Example.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Description)
            .HasMaxLength(500); 

        builder.Property(p => p.SellPrice)
            .HasColumnType("decimal(18,2)") 
            .IsRequired();

        builder.Property(p => p.CostPrice)
            .HasColumnType("decimal(18,2)")  
            .IsRequired();

        builder.Property(p => p.Quantity)
            .IsRequired(); 

        builder.Property(p => p.Discount)
            .IsRequired();  

        builder.Property(p => p.CategoryId)
            .IsRequired(false);

        builder.HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId);

        builder.HasMany(p => p.Products)
            .WithOne()
            .HasForeignKey(pt => pt.ProductId);

        builder.HasIndex(p => p.Name)
            .IsUnique();  

        builder.HasIndex(p => p.SellPrice);
    }
}
