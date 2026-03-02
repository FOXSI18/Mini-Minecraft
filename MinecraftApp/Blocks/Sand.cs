namespace MinecraftApp.Blocks;

public class Sand : Basisblock
{
    public Sand() : base("Sand", "yellow", 10)
    {
    }

    public override void Broken()
    {
        Console.WriteLine("The sand block was broken.");
    }
}