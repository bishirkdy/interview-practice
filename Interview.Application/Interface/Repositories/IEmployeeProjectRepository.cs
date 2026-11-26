using Interview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Interface.Repositories
{
    public interface IEmployeeProjectRepository : IGenericRepository<EmployeeProject>
    {
        Task AssignEmployeeAsync(Guid employeeId, Guid projectId);
        Task RemoveEmployeeAsync(Guid employeeId , Guid projectId);
        Task<bool> AssignmentExistsAsync(Guid employeeId, Guid projectId);
    }
}
