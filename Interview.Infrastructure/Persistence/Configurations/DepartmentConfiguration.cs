using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Infrastructure.Persistence.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<DepartmentEntity>
    {
        public void Configure(EntityTypeBuilder<DepartmentEntity> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.DepartmentName)
            .HasConversion<int>()
            .IsRequired();

            builder.HasIndex(d => d.DepartmentName)
                .IsUnique();
        }
    }
}
