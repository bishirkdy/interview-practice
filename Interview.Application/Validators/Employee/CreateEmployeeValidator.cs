using FluentValidation;
using Interview.Application.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Application.Validators.Employee
{
    public class CreateEmployeeValidator : AbstractValidator<CreateEmployeeDto>
    {
        public CreateEmployeeValidator()
        {
            RuleFor(e => e.Name)
               .NotEmpty()
               .WithMessage("Name is required.")
               .MaximumLength(50)
               .WithMessage("Name cannot exceed 50 characters.");

            RuleFor(e => e.Email)
                .NotEmpty()
                .WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Invalid email address.")
                .MaximumLength(256);

            RuleFor(e => e.Salary)
                .GreaterThan(0)
                .WithMessage("Salary must be greater than zero.");

            RuleFor(e => e.DepartmentId)
                .NotEmpty()
                .WithMessage("Department ID is required.");

            RuleFor(e => e.Password)
                .NotEmpty()
                .WithMessage("Password is required.")
                .MinimumLength(8)
                .WithMessage("Password must contain at least 8 characters.");
        }
    }
}
