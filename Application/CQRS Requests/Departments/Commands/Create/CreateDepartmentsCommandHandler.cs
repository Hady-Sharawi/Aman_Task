using Application.CQRS_Requests.Departments.DTOs.Request;
using Application.CQRS_Requests.Departments.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Departments.Commands.Create;

public class CreateDepartmentsCommandHandler : IRequestHandler<DepartmentCreateRequestDto, Result<DepartmentCreateResponseDto>>
{
    private readonly IRepository<Department> _context;
    private readonly IMapper _mapper;

    public CreateDepartmentsCommandHandler(IRepository<Department> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<DepartmentCreateResponseDto>> Handle(DepartmentCreateRequestDto request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Department>(request);

        return new Result<DepartmentCreateResponseDto>
        {
            IsSuccess = true,
            Data = _mapper.Map<DepartmentCreateResponseDto>(await _context.AddAsync(entity))
        };
    }
}