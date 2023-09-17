using Application.CQRS_Requests.Employees.DTOs.Request;
using Application.CQRS_Requests.Employees.DTOs.Response;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Employees.Queries.GetAll;

public class GetAllEmployeesQueryHandler : IRequestHandler<EmployeeGetAllRequestDto, Result<List<EmployeeGetAllResponseDto>>>
{
    private readonly IRepository<Employee> _context;
    private readonly IMapper _mapper;

    public GetAllEmployeesQueryHandler(IRepository<Employee> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<List<EmployeeGetAllResponseDto>>> Handle(EmployeeGetAllRequestDto request, CancellationToken cancellationToken)
    {
        return new Result<List<EmployeeGetAllResponseDto>>
        {
            IsSuccess = true,
            Data = await (await _context.GetAllAsync()).Data
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize)
                .ProjectTo<EmployeeGetAllResponseDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken)
        };
    }
}