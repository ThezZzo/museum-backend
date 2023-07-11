using Domain.Common.Repository;
using Infrasctructure.Persistance;

namespace Infrasctructure.Repositories.Department;

public class DepartmentRepository : 
    BaseRepository<Domain.Enteties.Department, ApplicationDbContext>,
    IDepartmentRepository
{
    
}