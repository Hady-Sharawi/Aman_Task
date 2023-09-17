using Application.CQRS_Requests.Departments.DTOs.Request;
using Application.CQRS_Requests.Departments.DTOs.Response;
using AutoMapper;
using Domain;
using Domain.Entities;
using MediatR;
using Persistence.GenericRepository;

namespace Application.CQRS_Requests.Departments.Queries.GetById;

public class GetByIdDepartmentsQueryHandler : IRequestHandler<DepartmentGetByIdRequestDto, Result<DepartmentGetByIdResponseDto>>
{
    private readonly IRepository<Department> _context;
    private readonly IMapper _mapper;

    public GetByIdDepartmentsQueryHandler(IRepository<Department> context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Result<DepartmentGetByIdResponseDto>> Handle(DepartmentGetByIdRequestDto request, CancellationToken cancellationToken)
    {
        return new Result<DepartmentGetByIdResponseDto>
        {
            IsSuccess = true,
            Data =  _mapper.Map<DepartmentGetByIdResponseDto> 
                (await _context.GetByIdAsync(request.request.Id))
        };
    }
}