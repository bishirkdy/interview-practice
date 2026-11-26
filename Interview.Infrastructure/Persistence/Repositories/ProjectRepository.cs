using Interview.Application.Interface.Repositories;
using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Infrastructure.Persistence.Repositories
{
    public class ProjectRepository(ApplicationDbContext context) : GenericRepository<ProjectEntity>(context) , IProjectRepository
    {
        public async Task<ProjectEntity?> GetWithEmployeesAsync(Guid ProjectId)
        {
            return await context.Projects
                .AsNoTracking()
                .Include(p => p.EmployeeProjects)
                .FirstOrDefaultAsync(p => p.Id == ProjectId);
        }
        public async Task<IEnumerable<ProjectEntity>> GetByEmployeeIdAsync(Guid employeeId)
        {
            return await context.Projects
                .AsNoTracking()
                .Where(p => p.EmployeeProjects
                    .Any(ep => ep.EmployeeId == employeeId))
                .ToListAsync();
        }
    }
}
