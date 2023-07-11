namespace Domain.Enteties;

public class Employee
{
    public Guid Id { get; init; } 
    
    private string Name { get; init; } 
    
    private string FamilyName { get; init; }
    
    private string SurName { get; init; }
    
    public Department Department { get; init; }

    private DateTime DateCreated { get; init; }
    
    public string Job { get; init; }

    public Employee Create(string name, string familyName, string surName, Department department, string job)
    {
        return new Employee
        {
            Name = name,
            FamilyName = familyName,
            SurName = surName,
            Department = department,
            Job = job,
            DateCreated = DateTime.UtcNow
        };
    }
    
}