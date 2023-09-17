using Application.CQRS_Requests.Departments.DTOs.Request;
using Application.CQRS_Requests.Departments.DTOs.Response;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Departments.Queries.GetAll;

public class GetAllDepartmentsQueryHandler : IRequestHandler<DepartmentGetAllRequestDto, Result<List<DepartmentGetAllResponseDto>>>
{
    private readonly IRepository<Department> _context;
    private readonly IMapper _mapper;

    public GetAllDepartmentsQueryHandler(IRepository<Department> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<List<DepartmentGetAllResponseDto>>> Handle(DepartmentGetAllRequestDto request, CancellationToken cancellationToken)
    {
        return new Result<List<DepartmentGetAllResponseDto>>
        {
            IsSuccess = true,
            Data = await (await _context.GetAllAsync()).Data
                .AsNoTracking()
                .OrderBy(x => x.DepName)
                .Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize)
                .ProjectTo<DepartmentGetAllResponseDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken)
        };
    }
}