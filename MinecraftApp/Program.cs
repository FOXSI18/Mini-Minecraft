using MinecraftApp.Blocks;

namespace MinecraftApp;

class Program
{
    static void Main()
    {
        List<Basisblock> world = new List<Basisblock>
        {
            new IronOre(),
            new Wood(),
            new Sand()
        };

        Console.WriteLine("Welcome to Mini Minecraft!");
        Console.WriteLine("You can choose your tool:");
        Console.WriteLine("1 = Hand");
        Console.WriteLine("2 = Pickaxe");
        Console.WriteLine("3 = Shovel");
        Console.WriteLine("4 = Axe");

        Tool selectedTool = (Tool)Convert.ToInt32(Console.ReadLine());

        foreach (var block in world)
        {
            block.ShowInfo();
            block.Break(selectedTool);
        }

        Console.WriteLine("All blocks have been destroyed!");
    }
}