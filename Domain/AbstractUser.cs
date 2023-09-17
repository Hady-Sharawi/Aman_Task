namespace Domain;

public abstract class AbstractUser : BaseEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
}
