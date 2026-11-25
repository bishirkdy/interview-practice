using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Domain.Entities
{
    public class DepartmentEntity
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public ICollection<EmployeeEntity> Employees { get; set; }
            = new List<EmployeeEntity>();
    }
}
