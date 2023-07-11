namespace Domain.Entities;

public class Department
{
    public int Id { get; init; }
    
    public string Name { get; set; }
    
    public Employee Employee { get; set; }
    
    public static Department Create(string name)
    {
        return new Department
        {
            Name = name
        };
    }
}