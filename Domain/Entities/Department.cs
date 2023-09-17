namespace Domain.Entities;

public class Department : BaseEntity
{
    public string DepName { get; set; }
    public virtual ICollection<Employee> Employees { get; private set; }
}
