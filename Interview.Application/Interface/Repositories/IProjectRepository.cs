using Interview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Interface.Repositories
{
    public interface IProjectRepository
    {
        Task<ProjectEntity?> GetWithEmployeesAsync(Guid ProjectId);
        Task<IEnumerable<ProjectEntity>> GetByEmployeeIdAsync(Guid employeeId);
    }
}
