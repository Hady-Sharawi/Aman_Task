using Application.CQRS_Requests.Departments.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Departments.Commands.Update;

public class UpdateDepartmentsCommandValidator : AbstractValidator<DepartmentCreateRequestDto>
{
    public UpdateDepartmentsCommandValidator()
    {
        RuleFor(c => c.request).NotNull();
        RuleFor(c => c.request).NotEmpty();
    }
}
