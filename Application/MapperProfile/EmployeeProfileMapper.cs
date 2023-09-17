using Application.CQRS_Requests.Employees.DTOs.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.MapperProfile;

public class EmployeeProfileMapper : Profile
{
    public EmployeeProfileMapper()
    {
        CreateProjection<Employee, EmployeeGetAllResponseDto>();
        CreateProjection<Employee, EmployeeGetByIdResponseDto>();
        CreateProjection<Employee, EmployeeGetByDepartmentIdResponseDto>();
        CreateProjection<Employee, EmployeeCreateResponseDto>();
        CreateProjection<Employee, EmployeeUpdateResponseDto>();
        CreateProjection<Employee, EmployeeDeleteResponseDto>();

        CreateMap<Employee, EmployeeGetByIdResponseDto>().ReverseMap();
    }
}
