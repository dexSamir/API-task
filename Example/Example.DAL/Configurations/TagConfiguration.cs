using Example.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable("Tags");

        builder.Property(t => t.Name)
            .IsRequired()  
            .HasMaxLength(100);

        builder.HasMany(t => t.Tags)
            .WithOne()
            .HasForeignKey(pt => pt.TagId);

        builder.HasIndex(t => t.Name) 
            .IsUnique();  
    }
}
