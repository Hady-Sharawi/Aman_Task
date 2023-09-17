using Application.CQRS_Requests.Departments.DTOs.Request;
using Application.CQRS_Requests.Departments.DTOs.Response;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class DepartmentController : BaseController
    {
        [HttpPost(nameof(Create))]
        public async Task<ActionResult<Result<DepartmentCreateResponseDto>>> Create([FromBody] DepartmentCreateResponseDto request, CancellationToken cancellationToken)
             => await Mediator.Send(new DepartmentCreateRequestDto(request), cancellationToken);

        [HttpGet("{id}")]
        public async Task<ActionResult<Result<DepartmentGetByIdResponseDto>>> GetById([FromQuery] DepartmentGetByIdResponseDto request, CancellationToken cancellationToken)
            => await Mediator.Send(new DepartmentGetByIdRequestDto(request), cancellationToken);
    }
}
