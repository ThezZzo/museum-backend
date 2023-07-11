using Microsoft.EntityFrameworkCore;

namespace Domain.Common.Repository;

public class BaseRepository<TEntity, TDbContext> : IBaseRepository<TEntity>
    where TEntity : class
    where TDbContext : DbContext
{
    protected BaseRepository()
    {
        
    }

    private readonly TDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;
    
    protected BaseRepository(TDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }
    public async Task<TEntity> GetEntityByIdAsync(int id, CancellationToken cancellationToken)
    {
        var item = await _dbSet.FindAsync(id, cancellationToken);
        if (item == null)
        {
            throw new Exception($"Сущность {nameof(TEntity)} с ключом {id} не найдена");
        }
        
        return item;
    }

    public async Task<bool> UpdateEntityAsync(TEntity entity, int id, CancellationToken cancellationToken)
    {
        var item = GetEntityByIdAsync(id, cancellationToken);
        if (item == null)
        {
            throw new Exception($"Сущность {entity} с ключом {id} не найдена");
        }

        _dbSet.Attach(entity);
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<IEnumerable<TEntity>> GetAllEntityAsync(CancellationToken cancellationToken)
    {
        var list = await _dbSet.ToListAsync(cancellationToken);
        if (list == null)
        {
            throw new Exception($"Список {nameof(TEntity)} пуст");
        }

        return list;
    }

    public async Task<bool> DeleteEntityAsync(int id, CancellationToken cancellationToken)
    {
        var item = await GetEntityByIdAsync(id, cancellationToken);
        if (item == null)
        {
            throw new Exception();
        }

        _dbSet.Remove(item);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }

    public async Task<bool> AddEntityAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await _dbSet.AddAsync(entity, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }
}