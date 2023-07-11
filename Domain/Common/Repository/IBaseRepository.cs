namespace Domain.Common.Repository;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetEntityByIdAsync(int id, CancellationToken cancellationToken);

    Task<bool> UpdateEntityAsync(TEntity entity, int id, CancellationToken cancellationToken);

    Task<IEnumerable<TEntity>> GetAllEntityAsync(CancellationToken cancellationToken);

    Task<bool> DeleteEntityAsync(int id, CancellationToken cancellationToken);

    Task<bool> AddEntityAsync(TEntity entity, CancellationToken cancellationToken);
    
}