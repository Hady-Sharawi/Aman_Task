using Application.CQRS_Requests.Employees.DTOs.Response;
using Domain;
using MediatR;

namespace Application.CQRS_Requests.Employees.DTOs.Request;

public record EmployeeDeleteRequestDto(EmployeeDeleteResponseDto requestDto) : IRequest<Result<EmployeeDeleteResponseDto>>
{
    //public Guid Id { get; set; }
}
