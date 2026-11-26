using Interview.Application.Interface.Repositories;
using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Infrastructure.Persistence.Repositories
{
    public class EmployeeProjectRepository(ApplicationDbContext context) : GenericRepository<EmployeeProject>(context) , IEmployeeProjectRepository
    {
        public async Task AssignEmployeeAsync(Guid employeeId, Guid projectId)
        {
            context.EmployeeProjects.Add(new EmployeeProject
            {
                EmployeeId = employeeId,
                ProjectId = projectId
            });

            await context.SaveChangesAsync();
        }
        public async Task RemoveEmployeeAsync(Guid employeeId, Guid projectId)
        {
            var assignment = await context.EmployeeProjects
                .FindAsync(employeeId, projectId);

            if (assignment == null)
                return;

            context.EmployeeProjects.Remove(assignment);

            await context.SaveChangesAsync();
        }
        public async Task<bool> AssignmentExistsAsync(Guid employeeId, Guid projectId)
            {
                return await context.EmployeeProjects
                    .AnyAsync(ep => ep.EmployeeId == employeeId && ep.ProjectId == projectId);
            }
    }
}
