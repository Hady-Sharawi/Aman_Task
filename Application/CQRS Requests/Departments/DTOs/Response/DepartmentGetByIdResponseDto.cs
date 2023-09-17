namespace Application.CQRS_Requests.Departments.DTOs.Response;

public class DepartmentGetByIdResponseDto
{
    public Guid Id { get; set; }
    public string DepName { get; set; }
}
