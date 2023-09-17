using Domain;
using MediatR;
using Application.CQRS_Requests.Departments.DTOs.Response;

namespace Application.CQRS_Requests.Departments.DTOs.Request;

public record DepartmentGetByIdRequestDto(DepartmentGetByIdResponseDto request) : IRequest<Result<DepartmentGetByIdResponseDto>>
{
    //public Guid Id { get; set; }
}
