using Application.CQRS_Requests.Departments.DTOs.Request;
using FluentValidation;

namespace Application.CQRS_Requests.Departments.Queries.GetById;

public class GetByIdDepartmentsQueryValidator : AbstractValidator<DepartmentGetByIdRequestDto>
{
    public GetByIdDepartmentsQueryValidator()
    {
        RuleFor(c => c.request).NotNull();
        RuleFor(c => c.request).NotEmpty();
    }
}
