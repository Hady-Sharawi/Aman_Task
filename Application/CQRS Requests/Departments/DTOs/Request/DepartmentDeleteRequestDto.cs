using Application.CQRS_Requests.Departments.DTOs.Response;
using Domain;
using MediatR;

namespace Application.CQRS_Requests.Departments.DTOs.Request;

public class DepartmentDeleteRequestDto : IRequest<Result<DepartmentDeleteResponseDto>>
{
    public Guid Id { get; set; }
}
