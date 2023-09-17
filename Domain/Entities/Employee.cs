namespace Domain.Entities;

public class Employee : AbstractUser
{
    public Guid DepartmentId { get; set; }
    public virtual Department Department { get; set; }
}
