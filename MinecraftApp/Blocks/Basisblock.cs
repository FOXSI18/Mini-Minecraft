namespace MinecraftApp.Blocks;

public abstract class Basisblock
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }

    public Basisblock(string name, string color, int speed)
    {
        Name = name;
        Color = color;
        Speed = speed;
    }

    public virtual void Broken()
    {
        Console.WriteLine("The {0} block was broken at a rate of {1}", Name, Speed);
    }
    
    public virtual void Info()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Color: {0}", Color);
        Console.WriteLine("Speed: {0}", Speed);
    }

    
}