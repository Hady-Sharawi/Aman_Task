namespace Domain;

public class Result<T>
{
    public bool IsSuccess { get; set; } = default;
    public string? ErrorMessage { get; set; }
    public T? Data { get; set; } = default;
}
