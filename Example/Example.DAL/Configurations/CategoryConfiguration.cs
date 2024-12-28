﻿using Example.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DAL.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasIndex(x => x.Name)
                 .IsUnique();
        builder.Property(x => x.Name)
            .HasMaxLength(32);
        builder.Property(x => x.Icon)
            .HasMaxLength(128);
    }
}
