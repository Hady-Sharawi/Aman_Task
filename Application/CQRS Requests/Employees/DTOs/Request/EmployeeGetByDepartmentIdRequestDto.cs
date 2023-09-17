using Domain;
using MediatR;
using Application.CQRS_Requests.Employees.DTOs.Response;

namespace Application.CQRS_Requests.Employees.DTOs.Request;

public record EmployeeGetByDepartmentIdRequestDto(EmployeeGetByDepartmentIdResponseDto requestDto) : IRequest<Result<List<EmployeeGetByDepartmentIdResponseDto>>>
{
    //public Guid DepartmentId { get; set; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}
