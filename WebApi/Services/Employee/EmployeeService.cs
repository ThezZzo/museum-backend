using Infrasctructure.Repositories.Employee;

namespace WebApi.Services.Employee;

public class EmployeeService
{
    private readonly IEmployeeRepository _repository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _repository = employeeRepository;
    }

    public async Task<Domain.Enteties.Employee> GetEmployee(int id, CancellationToken cancellationToken)
    {
        return await _repository.GetEntityByIdAsync(id, cancellationToken);
    }

    public async Task<IEnumerable<Domain.Enteties.Employee>> GetAllEmployee(CancellationToken cancellationToken)
    {
        return await _repository.GetAllEntityAsync(cancellationToken);
    }
}