using Application.CQRS_Requests.Employees.DTOs.Response;
using Domain;
using MediatR;

namespace Application.CQRS_Requests.Employees.DTOs.Request;

public record EmployeeCreateRequestDto(EmployeeCreateResponseDto requestDto) : IRequest<Result<EmployeeCreateResponseDto>>
{
}
