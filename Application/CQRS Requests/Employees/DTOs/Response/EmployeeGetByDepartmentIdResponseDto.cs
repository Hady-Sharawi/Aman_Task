namespace Application.CQRS_Requests.Employees.DTOs.Response;

public class EmployeeGetByDepartmentIdResponseDto
{
    public Guid DepartmentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
