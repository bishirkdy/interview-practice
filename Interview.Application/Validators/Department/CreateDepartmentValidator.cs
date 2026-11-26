using FluentValidation;
using Interview.Application.DTO.Department;

namespace Interview.Application.Validators.Department
{
    public class CreateDepartmentValidator
        : AbstractValidator<CreateDepartmentDto>
    {
        public CreateDepartmentValidator()
        {
            RuleFor(d => d.DepartmentName)
                .IsInEnum()
                .WithMessage("Invalid department type.");
        }
    }
}