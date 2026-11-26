using Interview.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Domain.Entities
{
    public class EmployeeEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public EmployeeRole Role { get; set; } = EmployeeRole.Employee;
        public Guid DepartmentId { get; set; }
        public string PasswordHash { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();
        public DepartmentEntity department { get; set; } = null!;
        public EmployeeProfile Profile { get; set; }
        public ICollection<EmployeeProject> employeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
