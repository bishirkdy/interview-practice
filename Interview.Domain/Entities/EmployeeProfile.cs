using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Domain.Entities
{
    public class EmployeeProfile
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Phone { get; set; } = string.Empty;
        public EmployeeEntity employee { get; set; } = null!;
    }
}
