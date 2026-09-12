using static Enum;
public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int Rating { get; set; }
    public Category Category { get; set; }
    public bool Watched { get; set; }
    public bool CanRewatch { get; set; }
    public Language Language { get; set; }
    public string Description { get; set; } = string.Empty;
}