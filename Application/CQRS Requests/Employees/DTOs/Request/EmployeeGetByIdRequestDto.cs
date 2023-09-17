using Domain;
using MediatR;
using Application.CQRS_Requests.Employees.DTOs.Response;

namespace Application.CQRS_Requests.Employees.DTOs.Request;

public record EmployeeGetByIdRequestDto(Guid Id) : IRequest<Result<EmployeeGetByIdResponseDto>>
{
    //public Guid Id { get; set; }
}
