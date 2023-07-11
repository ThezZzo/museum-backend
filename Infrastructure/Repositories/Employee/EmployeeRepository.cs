

using Domain.Common.Repository;
using Infrasctructure.Persistance;
using Infrasctructure.Repositories.Employee;

namespace Infrastructure.Repositories.Employee;

public class EmployeeRepository : 
    BaseRepository<Domain.Entities.Employee, ApplicationDbContext>, 
    IEmployeeRepository
{
    public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        
    }
    
}