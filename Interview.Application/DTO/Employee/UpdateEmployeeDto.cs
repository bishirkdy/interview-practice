using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.DTO.Employee
{
    public class UpdateEmployeeDto
    {
        public string? Name { get; set; }
        public decimal? Salary { get; set; }
        public Guid? DepartmentId { get; set; }
        public string? Password { get; set; }

    }
}
