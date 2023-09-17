using Application.CQRS_Requests.Employees.DTOs.Request;
using Application.CQRS_Requests.Employees.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Employees.Commands.Create;

public class CreateEmployeesCommandHandler : IRequestHandler<EmployeeCreateRequestDto, Result<EmployeeCreateResponseDto>>
{
    private readonly IRepository<Employee> _context;
    private readonly IMapper _mapper;

    public CreateEmployeesCommandHandler(IRepository<Employee> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<EmployeeCreateResponseDto>> Handle(EmployeeCreateRequestDto request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Employee>(request);

        return new Result<EmployeeCreateResponseDto>
        {
            IsSuccess = true,
            Data = _mapper.Map<EmployeeCreateResponseDto>(await _context.AddAsync(entity))
        };
    }
}