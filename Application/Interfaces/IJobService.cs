using System.Net;
using Domain.Enteties;

namespace Application.Interfaces;

public interface IJobService
{
    Task<bool> AddJob(string name, CancellationToken cancellationToken);

    Task<IEnumerable<Job>> GetAllJob(CancellationToken cancellationToken);

    Task<Job> GetByIdJob(int id, CancellationToken cancellationToken);

    Task<bool> UpdateJob(string name, int id, CancellationToken cancellationToken);

    Task<bool> DeleteJob(int id, CancellationToken cancellationToken);
}