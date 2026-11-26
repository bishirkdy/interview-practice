using Interview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Interface.External
{
    public interface IJwtTokenService
    {
        string GenerateToken(EmployeeEntity entity);
    }
}
