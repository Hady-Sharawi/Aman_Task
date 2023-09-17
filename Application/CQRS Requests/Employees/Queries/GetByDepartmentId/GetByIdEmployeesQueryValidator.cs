using Application.CQRS_Requests.Employees.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Departments.Queries.GetByDepartmentId;

public class GetByIdEmployeesQueryValidator : AbstractValidator<EmployeeGetByDepartmentIdRequestDto>
{
    public GetByIdEmployeesQueryValidator()
    {
        RuleFor(c => c.requestDto).NotNull();
        RuleFor(c => c.requestDto).NotEmpty();
    }
}
