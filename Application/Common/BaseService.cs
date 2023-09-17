using Application.ICommon;
using Domain;

namespace Application.Common;

public class BaseService<TDto> : IBaseService<TDto>
{
    public Task<Result<TDto>> Create()
    {
        throw new NotImplementedException();
    }

    public Task<Result<TDto>> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<TDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Result<TDto>> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<TDto>> Update(TDto entity)
    {
        throw new NotImplementedException();
    }
}
