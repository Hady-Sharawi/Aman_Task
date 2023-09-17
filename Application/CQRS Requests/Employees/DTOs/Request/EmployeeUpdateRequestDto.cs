using Domain;
using MediatR;
using Application.CQRS_Requests.Employees.DTOs.Response;

namespace Application.CQRS_Requests.Employees.DTOs.Request;

public class EmployeeUpdateRequestDto : IRequest<Result<EmployeeUpdateResponseDto>>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
