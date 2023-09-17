using Domain;

namespace Application.ICommon;

/// <summary>
/// Basic Controller API Methods
/// </summary>
public interface IBaseService<TDto>
{
    Task<Result<TDto>> GetAll();
    Task<Result<TDto>> GetById(Guid id);
    Task<Result<TDto>> Create();
    Task<Result<TDto>> Delete(Guid id);
    Task<Result<TDto>> Update(TDto entity);
}
