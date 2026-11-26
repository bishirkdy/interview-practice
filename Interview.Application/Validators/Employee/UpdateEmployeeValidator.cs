using FluentValidation;
using Interview.Application.DTO.Employee;

namespace Interview.Application.Validators.Employee
{
    public class UpdateEmployeeValidator : AbstractValidator<UpdateEmployeeDto>
    {
        public UpdateEmployeeValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .WithMessage("Name cannot be empty.")
                .MaximumLength(50)
                .WithMessage("Name cannot exceed 50 characters.")
                .When(e => e.Name != null);

            RuleFor(e => e.Salary)
                .GreaterThan(0)
                .WithMessage("Salary must be greater than zero.")
                .When(e => e.Salary.HasValue);

            RuleFor(e => e.DepartmentId)
                .NotEqual(Guid.Empty)
                .WithMessage("Invalid department ID.")
                .When(e => e.DepartmentId.HasValue);
        }
    }
}