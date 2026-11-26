using Interview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.DTO.Employee
{
    public class EmployeeResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public Guid DepartmentId { get; set; }
        public string Role { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();
        public DepartmentEntity department { get; set; } = null!;
    }
}
