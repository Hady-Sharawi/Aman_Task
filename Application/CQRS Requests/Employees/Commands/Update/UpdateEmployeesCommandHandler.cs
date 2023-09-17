using Application.CQRS_Requests.Employees.DTOs.Request;
using Application.CQRS_Requests.Employees.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Employees.Commands.Update;

public class UpdateEmployeesCommandHandler : IRequestHandler<EmployeeUpdateRequestDto, Result<EmployeeUpdateResponseDto>>
{
    private readonly IRepository<Employee> _context;
    private readonly IMapper _mapper;

    public UpdateEmployeesCommandHandler(IRepository<Employee> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<EmployeeUpdateResponseDto>> Handle(EmployeeUpdateRequestDto request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Employee>(request);

        return new Result<EmployeeUpdateResponseDto>
        {
            IsSuccess = true,
            Data = _mapper.Map<EmployeeUpdateResponseDto>(await _context.Update(entity))
        };
    }
}