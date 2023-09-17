using Application.CQRS_Requests.Employees.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Employees.Commands.Create;

public class CreateEmployeesCommandValidator : AbstractValidator<EmployeeCreateRequestDto>
{
    public CreateEmployeesCommandValidator()
    {
        RuleFor(c => c.requestDto).NotNull();
        RuleFor(c => c.requestDto).NotEmpty();

        RuleFor(c => c.requestDto.Age)
            .NotNull()
            .GreaterThanOrEqualTo(18)
            .LessThanOrEqualTo(200);
    }
}
