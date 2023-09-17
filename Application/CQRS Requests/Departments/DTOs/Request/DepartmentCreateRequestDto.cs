using Application.CQRS_Requests.Departments.DTOs.Response;
using Domain;
using MediatR;

namespace Application.CQRS_Requests.Departments.DTOs.Request;

public record DepartmentCreateRequestDto(DepartmentCreateResponseDto request) : IRequest<Result<DepartmentCreateResponseDto>>
{
    //public string DepName { get; set; }
}
