using Domain;
using MediatR;
using Application.CQRS_Requests.Departments.DTOs.Response;

namespace Application.CQRS_Requests.Departments.DTOs.Request;

public class DepartmentGetAllRequestDto : IRequest<Result<List<DepartmentGetAllResponseDto>>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}
