using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Domain.Entities
{
    public class EmployeeProject
    {
        public Guid EmployeeId { get; set; }
        public Guid ProjectId { get; set; }
        public EmployeeEntity Employee { get; set; } = null!;
        public ProjectEntity Project { get; set; } = null!;
    }
}
