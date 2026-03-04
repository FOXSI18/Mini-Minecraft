namespace MinecraftApp.Blocks;

public abstract class Basisblock
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int BreakTime { get; set; }

    protected Basisblock(string name, string color, int breakTime)
    {
        Name = name;
        Color = color;
        BreakTime = breakTime;
    }
    
    public virtual void ShowInfo()
    {
        
        if (Color == "yellow")
            Console.ForegroundColor = ConsoleColor.Yellow;
        if (Color == "green")
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        if (Color == "gray")
            Console.ForegroundColor = ConsoleColor.Gray;
        
        Console.WriteLine($"Block: {Name}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Break Time: {BreakTime} Seconds");
        
    }

    public virtual int CalculateBreakTime(Tool tool)
    {
        return BreakTime;
    }

     public void Break(Tool tool)
    {
        int time = CalculateBreakTime(tool);

        Console.WriteLine($"\nBreaking {Name} with {tool}...\n");

        for (int i = 1; i <= time; i++)
        {
            Console.WriteLine($"Time: {i} seconds");
            Thread.Sleep(1000);
        }

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{Name} was broken!\n");
        Console.ResetColor();
    }
}

    

