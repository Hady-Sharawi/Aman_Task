using Application.CQRS_Requests.Employees.DTOs.Request;
using Application.CQRS_Requests.Employees.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Employees.Commands.Delete;

public class DeleteEmployeesCommandHandler : IRequestHandler<EmployeeDeleteRequestDto, Result<EmployeeDeleteResponseDto>>
{
    private readonly IRepository<Employee> _context;
    private readonly IMapper _mapper;

    public DeleteEmployeesCommandHandler(IRepository<Employee> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<EmployeeDeleteResponseDto>> Handle(EmployeeDeleteRequestDto request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Employee>(request);

        return new Result<EmployeeDeleteResponseDto>
        {
            IsSuccess = true,
            Data = _mapper.Map<EmployeeDeleteResponseDto>(await _context.Delete(entity))
        };
    }
}