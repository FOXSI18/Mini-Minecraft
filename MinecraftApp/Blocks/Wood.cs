namespace MinecraftApp.Blocks;

public class Wood : Basisblock
{
    public Wood() : base("Wood", "brown", 15)
    {
    }
    
    public override void Broken()
    {
        Console.WriteLine("The wood block was broken.");
    }
}