using Application.CQRS_Requests.Employees.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Employees.Queries.GetAll;

public class GetAllEmployeesQueryValidator : AbstractValidator<EmployeeGetAllRequestDto>
{
    public GetAllEmployeesQueryValidator()
    {
        RuleFor(c => c.PageNumber).NotNull();
        RuleFor(c => c.PageSize).NotNull();
    }
}
