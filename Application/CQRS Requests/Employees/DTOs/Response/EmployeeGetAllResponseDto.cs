namespace Application.CQRS_Requests.Employees.DTOs.Response;

public class EmployeeGetAllResponseDto
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
