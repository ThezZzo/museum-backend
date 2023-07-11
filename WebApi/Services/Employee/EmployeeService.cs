using Infrasctructure.Repositories.Employee;

namespace WebApi.Services.Employee;

public class EmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _repository = employeeRepository;
    }

    public async Task<Domain.Entities.Employee> GetEmployee(int id, CancellationToken cancellationToken)
    {
        return await _repository.GetEntityByIdAsync(id, cancellationToken);
    }

    public async Task<IEnumerable<Domain.Entities.Employee>> GetAllEmployee(CancellationToken cancellationToken)
    {
        return await _repository.GetAllEntityAsync(cancellationToken);
    }
}