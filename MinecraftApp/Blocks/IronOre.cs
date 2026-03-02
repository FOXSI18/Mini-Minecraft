namespace MinecraftApp.Blocks;

public class IronOre : Basisblock
{
    public IronOre() : base("Iron Ore", "gray", 20)
    {
    }
    
    public override void Broken()
    {
        Console.WriteLine("The Iron Ore block was broken.");
    }
}