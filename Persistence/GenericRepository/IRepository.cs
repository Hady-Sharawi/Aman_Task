using Domain;
using System.Linq.Expressions;

namespace Persistence.GenericRepository;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<Result<IQueryable<TEntity>>> GetAllAsync();
    Task<Result<TEntity>> GetByIdAsync(Guid id);
    Task<Result<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> predicate);
    Task<Result<TEntity>> AddAsync(TEntity entity);
    Task<Result<TEntity>> Update(TEntity entity);
    Task<Result<TEntity>> Delete(TEntity entity);
    Task<bool> SaveChangesAsync();
}
