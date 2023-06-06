namespace DotNetRPG.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "player";
    public int Hp { get; set; } = 100;
    public int Str { get; set; } = 10;
    public int Def { get; set; } = 10;
    public int Int { get; set; } = 10;
    public Job Job { get; set; } = Job.Warrior;
} 