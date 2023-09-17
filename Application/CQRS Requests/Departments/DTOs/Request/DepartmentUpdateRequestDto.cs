using Domain;
using MediatR;
using Application.CQRS_Requests.Departments.DTOs.Response;

namespace Application.CQRS_Requests.Departments.DTOs.Request;

public class DepartmentUpdateRequestDto : IRequest<Result<DepartmentUpdateResponseDto>>
{
    public Guid Id { get; set; }
    public string DepName { get; set; }
}
