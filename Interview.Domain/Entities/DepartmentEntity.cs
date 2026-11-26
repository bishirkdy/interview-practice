using Interview.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Domain.Entities
{
    public class DepartmentEntity
    {
        public Guid Id { get; set; }
        public Department DepartmentName { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }
            = new List<EmployeeEntity>();
    }
}
