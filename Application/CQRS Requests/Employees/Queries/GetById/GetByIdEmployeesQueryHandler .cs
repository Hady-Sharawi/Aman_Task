using Application.CQRS_Requests.Employees.DTOs.Request;
using Application.CQRS_Requests.Employees.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Departments.Queries.GetById;

public class GetByIdEmployeesQueryHandler : IRequestHandler<EmployeeGetByIdRequestDto, Result<EmployeeGetByIdResponseDto>>
{
    private readonly IRepository<Employee> _context;
    private readonly IMapper _mapper;

    public GetByIdEmployeesQueryHandler(IRepository<Employee> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<EmployeeGetByIdResponseDto>> Handle(EmployeeGetByIdRequestDto request, CancellationToken cancellationToken)
    {
        return new Result<EmployeeGetByIdResponseDto>
        {
            IsSuccess = true,
            Data =  _mapper.Map<Employee, EmployeeGetByIdResponseDto> 
                ((await _context.GetByIdAsync(request.Id)).Data)
        };
    }
}