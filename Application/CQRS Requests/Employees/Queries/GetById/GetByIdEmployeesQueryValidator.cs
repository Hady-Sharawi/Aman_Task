using Application.CQRS_Requests.Employees.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Departments.Queries.GetById;

public class GetByIdEmployeesQueryValidator : AbstractValidator<EmployeeGetByIdRequestDto>
{
    public GetByIdEmployeesQueryValidator()
    {
        RuleFor(c => c.Id).NotNull();
        RuleFor(c => c.Id).NotEmpty();
    }
}
