namespace Domain.Entities;

public class Employee
{
    public Guid Id { get; init; } 
    
    public string Name { get; init; } 
    
    public string FamilyName { get; init; }
    
    public string SurName { get; init; }
    
    public IEnumerable<Department> Department { get; set; }

    public DateTime DateCreated { get; init; }
    
    public IEnumerable<Job> Job { get; set; }
    
    public string ImagePath { get; set; }

    public Employee()
    {
        Id = Guid.NewGuid();
        DateCreated = DateTime.UtcNow;
    }
    public static Employee Create(string name, string familyName, string surName)
    {
        return new Employee
        {
            Name = name,
            FamilyName = familyName,
            SurName = surName,
            DateCreated = DateTime.UtcNow
        };
    }
    
}