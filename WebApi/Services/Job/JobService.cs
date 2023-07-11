using System.Net;
using Application.Interfaces;
using Infrastructure.Repositories.Job;

namespace WebApi.Services.Job;

public class JobService : IJobService
{
    private readonly IJobRepository _repository;

    public JobService(IJobRepository jobRepository)
    {
        _repository = jobRepository;
    }
    
    public async Task<bool> AddJob(string name, CancellationToken cancellationToken)
    {
        var entity = Domain.Entities.Job.Create(name);
        await _repository.AddEntityAsync(entity, cancellationToken);
        return true;
    }
    
    public async Task<IEnumerable<Domain.Entities.Job>> GetAllJob(CancellationToken cancellationToken)
    {
        var list = await _repository.GetAllEntityAsync(cancellationToken);
        return list;
    }
    
    public async Task<Domain.Entities.Job> GetByIdJob(int id, CancellationToken cancellationToken)
    {
        var item = await _repository.GetEntityByIdAsync(id, cancellationToken);
        return item;
    }
    
    public async Task<bool> UpdateJob(string name, int id, CancellationToken cancellationToken)
    {
        var entity = Domain.Entities.Job.Create(name);
        await _repository.UpdateEntityAsync(entity, id, cancellationToken);
        return true;
    }
    
    public async Task<bool> DeleteJob(int id, CancellationToken cancellationToken)
    {
        await _repository.DeleteEntityAsync(id, cancellationToken);
        return true;
    }
}