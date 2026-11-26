using Interview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Interface.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<EmployeeEntity>
    {
        Task<EmployeeEntity?> GetEmailAsync(string email);
        Task<IEnumerable<EmployeeEntity>> GetByDepartmentAsync(Guid departmentId);
        Task<bool> EmailExistsAsync(string email);
    }
}
