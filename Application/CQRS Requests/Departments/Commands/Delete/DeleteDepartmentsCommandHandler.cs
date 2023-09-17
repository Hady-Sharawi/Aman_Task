using Application.CQRS_Requests.Departments.DTOs.Request;
using Application.CQRS_Requests.Departments.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Departments.Commands.Delete;

public class DeleteDepartmentsCommandHandler : IRequestHandler<DepartmentDeleteRequestDto, Result<DepartmentDeleteResponseDto>>
{
    private readonly IRepository<Department> _context;
    private readonly IMapper _mapper;

    public DeleteDepartmentsCommandHandler(IRepository<Department> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<DepartmentDeleteResponseDto>> Handle(DepartmentDeleteRequestDto request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Department>(request);

        return new Result<DepartmentDeleteResponseDto>
        {
            IsSuccess = true,
            Data = _mapper.Map<DepartmentDeleteResponseDto>(await _context.Delete(entity))
        };
    }
}