using Application.CQRS_Requests.Employees.DTOs.Request;
using Application.CQRS_Requests.Employees.DTOs.Response;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class EmployeeController : BaseController
    {
        [HttpPost(nameof(Create))]
        public async Task<ActionResult<Result<EmployeeCreateResponseDto>>> Create([FromBody] EmployeeCreateResponseDto request, CancellationToken cancellationToken)
             => await Mediator.Send(new EmployeeCreateRequestDto(request), cancellationToken);

        [HttpGet("{id}")]
        public async Task<ActionResult<Result<EmployeeGetByIdResponseDto>>> GetById([FromQuery] Guid id, CancellationToken cancellationToken) 
            => await Mediator.Send(new EmployeeGetByIdRequestDto(id), cancellationToken);

        [HttpGet("{pageSize}/{pageNumber}")]
        public async Task<ActionResult<Result<List<EmployeeGetByDepartmentIdResponseDto>>>> GetByDepartmentId(
            [FromBody] EmployeeGetByDepartmentIdResponseDto request,
            [FromQuery] int ? pageSize, [FromQuery] int? pageNumber,
            CancellationToken cancellationToken)
            => await Mediator.Send(new EmployeeGetByDepartmentIdRequestDto(request), cancellationToken);
    }
}
