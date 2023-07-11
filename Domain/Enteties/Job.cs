namespace Domain.Enteties;

public class Job
{
    public int Id { get; init; }
    
    public string Name { get; set; }

    public static Job Create(string name)
    {
        return new Job
        {
            Name = name
        };
    }
}