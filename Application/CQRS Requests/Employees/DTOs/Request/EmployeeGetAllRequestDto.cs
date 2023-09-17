using Application.CQRS_Requests.Employees.DTOs.Response;
using Domain;
using MediatR;

namespace Application.CQRS_Requests.Employees.DTOs.Request;

public class EmployeeGetAllRequestDto : IRequest<Result<List<EmployeeGetAllResponseDto>>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}
