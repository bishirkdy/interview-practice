using Interview.Application.Interface.Repositories;
using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Interview.Infrastructure.Persistence.Repositories
{
    public class DepartmentRepository(ApplicationDbContext context) : GenericRepository<DepartmentEntity>(context) , IDepartmentRepository
    {
        public async Task<DepartmentEntity?> GetByNameAsync(string name)
        {
            return await context.Departments.FirstOrDefaultAsync(d => d.DepartmentName == name);
        }
        public async Task<DepartmentEntity?> GetWithEmployeesAsync()
        {
            return await context.Departments
                .AsNoTracking()
                .Include(d => d.Employees)
                .FirstOrDefaultAsync();                
        }
    }
}
