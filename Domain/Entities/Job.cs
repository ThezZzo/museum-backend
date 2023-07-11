namespace Domain.Entities;

public class Job
{
    public int Id { get; init; }
    
    public Employee Employee { get; set; }
    
    public string Name { get; set; }

    public static Job Create(string name)
    {
        return new Job
        {
            Name = name
        };
    }
}