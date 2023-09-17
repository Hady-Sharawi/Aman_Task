using Application.CQRS_Requests.Employees.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Employees.Commands.Delete;

public class DeleteEmployeesCommandValidator : AbstractValidator<EmployeeDeleteRequestDto>
{
    public DeleteEmployeesCommandValidator()
    {
        RuleFor(c => c.requestDto).NotNull();
        RuleFor(c => c.requestDto).NotEmpty();
    }
}
