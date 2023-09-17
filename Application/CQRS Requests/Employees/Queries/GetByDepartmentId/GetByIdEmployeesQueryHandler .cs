using Application.CQRS_Requests.Employees.DTOs.Request;
using Application.CQRS_Requests.Employees.DTOs.Response;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Departments.Queries.GetByDepartmentId;

public class GetByIdEmployeesQueryHandler : IRequestHandler<EmployeeGetByDepartmentIdRequestDto, Result<List<EmployeeGetByDepartmentIdResponseDto>>>
{
    private readonly IRepository<Employee> _context;
    private readonly IMapper _mapper;

    public GetByIdEmployeesQueryHandler(IRepository<Employee> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<List<EmployeeGetByDepartmentIdResponseDto>>> Handle(EmployeeGetByDepartmentIdRequestDto request, CancellationToken cancellationToken)
    {
        return new Result<List<EmployeeGetByDepartmentIdResponseDto>>
        {
            IsSuccess = true,
            Data = await (await _context.GetAllAsync()).Data
                .AsNoTracking()
                .Include(x=>x.Department)
                .Where(x=>x.DepartmentId == request.requestDto.DepartmentId)
                .OrderBy(x => x.Name)
                .Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize)
                .ProjectTo<EmployeeGetByDepartmentIdResponseDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken)
        };
    }
}