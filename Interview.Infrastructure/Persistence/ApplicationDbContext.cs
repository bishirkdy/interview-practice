using System;
using System.Collections.Generic;
using System.Text;
using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Interview.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        public DbSet<EmployeeEntity> Employees => Set<EmployeeEntity>();
        public DbSet<DepartmentEntity> Departments => Set<DepartmentEntity>();
        public DbSet<EmployeeProfile> EmployeeProfiles => Set<EmployeeProfile>();
        public DbSet<EmployeeProject> EmployeeProjects => Set<EmployeeProject>();
        public DbSet<ProjectEntity> Projects => Set<ProjectEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
