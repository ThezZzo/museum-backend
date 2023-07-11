using Domain.Common.Repository;
using Infrasctructure.Persistance;

namespace Infrastructure.Repositories.Job;

public class JobRepository : 
    BaseRepository<Domain.Enteties.Job, ApplicationDbContext> , 
    IJobRepository
{
    
}