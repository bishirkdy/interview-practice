using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Domain.Entities
{
    public class ProjectEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Decimal Budget { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
