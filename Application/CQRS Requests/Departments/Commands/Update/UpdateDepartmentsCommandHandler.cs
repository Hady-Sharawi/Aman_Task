using Application.CQRS_Requests.Departments.DTOs.Request;
using Application.CQRS_Requests.Departments.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Departments.Commands.Update;

public class UpdateDepartmentsCommandHandler : IRequestHandler<DepartmentUpdateRequestDto, Result<DepartmentUpdateResponseDto>>
{
    private readonly IRepository<Department> _context;
    private readonly IMapper _mapper;

    public UpdateDepartmentsCommandHandler(IRepository<Department> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<DepartmentUpdateResponseDto>> Handle(DepartmentUpdateRequestDto request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Department>(request);

        return new Result<DepartmentUpdateResponseDto>
        {
            IsSuccess = true,
            Data = _mapper.Map<DepartmentUpdateResponseDto>(await _context.Update(entity))
        };
    }
}