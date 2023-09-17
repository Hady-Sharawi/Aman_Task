using Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Persistence.GenericRepository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly DBContext _context;

    public Repository(DBContext context)
    {
        _context = context;
    }

    public Task<Result<IQueryable<TEntity>>> GetAllAsync()
    {
        return Task.FromResult(new Result<IQueryable<TEntity>>()
        {
            IsSuccess = true,
            Data = _context.Set<TEntity>().AsQueryable()
        });
    }

    public async Task<Result<TEntity>> GetByIdAsync(Guid id)
    {
        return new Result<TEntity>()
        {
            IsSuccess = true,
            Data = await _context.Set<TEntity>().SingleOrDefaultAsync(s => s.Id == id)
        };
    }

    public async Task<Result<TEntity>> AddAsync(TEntity entity)
    {
        entity.Id = new Guid();
        await _context.Set<TEntity>().AddAsync(entity);
        bool saveRes = await SaveChangesAsync();

        return new Result<TEntity>()
        {
            IsSuccess = saveRes,
            Data = entity
        };
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync().ConfigureAwait(false) > 0;
    }

    public async Task<Result<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return new Result<TEntity>()
        {
            IsSuccess = true,
            Data = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate)
        };
    }

    public async Task<Result<TEntity>> Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);

        bool saveRes = await SaveChangesAsync();

        return new Result<TEntity>()
        {
            IsSuccess = saveRes,
            Data = entity
        };
    }
    public async Task<Result<TEntity>> Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);

        return new Result<TEntity>()
        {
            IsSuccess = await SaveChangesAsync()
        };
    }
}
