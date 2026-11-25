using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Infrastructure.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name)
                .HasMaxLength(50);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.Property(e => e.Salary)
                .HasPrecision(18, 2);

            builder.Property(e => e.Balance)
                .HasPrecision(18, 2)
                .HasDefaultValue(0m);

            builder.Property(e => e.RowVersion)
                .IsRowVersion();

            builder.HasQueryFilter(e => !e.IsDeleted);

            builder.HasOne(e => e.department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasMany(e => e.employeeProjects)
                 .WithOne(p => p.Employee)
                 .HasForeignKey(p => p.EmployeeId);

        }
    }
}
