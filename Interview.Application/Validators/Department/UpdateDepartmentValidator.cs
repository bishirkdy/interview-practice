using FluentValidation;
using Interview.Application.DTO.Department;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Validators.Department
{
    public class UpdateDepartmentValidator : AbstractValidator<UpdateDepartmentDto>
    {
        public UpdateDepartmentValidator() {
            RuleFor(d => d.DepartmentName)  
                .IsInEnum()
                .WithMessage("Invalid department type.");


        }
    }
}
