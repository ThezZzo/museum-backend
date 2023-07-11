using Domain.Common.Repository;
using Infrasctructure.Persistance;

namespace Infrastructure.Repositories.Job;

public class JobRepository : 
    BaseRepository<Domain.Entities.Job, ApplicationDbContext> , 
    IJobRepository
{
    
}