using Interview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Interface.Repositories
{
    public interface IDepartmentRepository : IGenericRepository<DepartmentEntity>
    {
        Task<DepartmentEntity?> GetByNameAsync(string name);
        Task<DepartmentEntity?> GetWithEmployeesAsync();
    }
}
