using Interview.Application.Interface.Repositories;
using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Infrastructure.Persistence.Repositories
{
    public class EmployeeRepository(ApplicationDbContext context) :  GenericRepository<EmployeeEntity>(context) , IEmployeeRepository
    {
        
        public async Task<EmployeeEntity?> GetEmailAsync(string email)
        {
            return await context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<EmployeeEntity>> GetByDepartmentAsync(Guid departmentId)
        {
            return await context.Employees
                .Where(d => d.DepartmentId == departmentId)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<bool> EmailExistsAsync(string email)  
        {
            return await context.Employees.AnyAsync(e => e.Email == email);
        }
    }
}
