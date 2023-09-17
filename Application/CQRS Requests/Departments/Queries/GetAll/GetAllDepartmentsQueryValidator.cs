using Application.CQRS_Requests.Departments.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Departments.Queries.GetAll;

public class GetAllDepartmentsQueryValidator : AbstractValidator<DepartmentGetAllRequestDto>
{
    public GetAllDepartmentsQueryValidator()
    {
        RuleFor(c => c.PageNumber).NotNull();
        RuleFor(c => c.PageSize).NotNull();
    }
}
