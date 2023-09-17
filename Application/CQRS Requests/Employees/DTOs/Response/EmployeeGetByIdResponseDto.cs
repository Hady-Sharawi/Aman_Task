namespace Application.CQRS_Requests.Employees.DTOs.Response;

public class EmployeeGetByIdResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
