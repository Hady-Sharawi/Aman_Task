using Application.CQRS_Requests.Departments.DTOs.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.MapperProfile;

public class DepartmentProfileMapper : Profile
{
    public DepartmentProfileMapper()
    {
        CreateProjection<Department, DepartmentGetAllResponseDto>();
        CreateProjection<Department, DepartmentGetByIdResponseDto>();
        CreateProjection<Department, DepartmentCreateResponseDto>();
        CreateProjection<Department, DepartmentUpdateResponseDto>();
        CreateProjection<Department, DepartmentDeleteResponseDto>();

        CreateMap<Department, DepartmentGetByIdResponseDto>().ReverseMap();
    }
}