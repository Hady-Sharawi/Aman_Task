using Application.CQRS_Requests.Departments.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Departments.Commands.Create;

public class CreateDepartmentsCommandValidator : AbstractValidator<DepartmentCreateRequestDto>
{
    public CreateDepartmentsCommandValidator()
    {
        RuleFor(c => c.request).NotNull();
        RuleFor(c => c.request).NotEmpty();
    }
}
