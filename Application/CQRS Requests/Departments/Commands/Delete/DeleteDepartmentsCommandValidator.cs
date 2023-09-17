using Application.CQRS_Requests.Departments.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Departments.Commands.Delete;

public class DeleteDepartmentsCommandValidator : AbstractValidator<DepartmentDeleteRequestDto>
{
    public DeleteDepartmentsCommandValidator()
    {
        RuleFor(c => c.Id).NotNull();
        RuleFor(c => c.Id).NotEmpty();
    }
}
