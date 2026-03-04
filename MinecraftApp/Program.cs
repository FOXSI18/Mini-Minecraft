using MinecraftApp.Blocks;

namespace MinecraftApp;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Welcome to Mini Minecraft!");
        while (true)
        {
            List<Basisblock> world = new List<Basisblock>
            {
                new Sand(),
                new Wood(),
                new Iron(),
            };
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("You can choose your tool:");
            Console.WriteLine("1 = Hand");
            Console.WriteLine("2 = Pickaxe");
            Console.WriteLine("3 = Shovel");
            Console.WriteLine("4 = Axe");
            Console.WriteLine("5 = Exit\n");
            Console.ResetColor();

            Tool selectedTool;

            try
            {
                selectedTool = (Tool)Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (selectedTool == Tool.Exit)
                    break;

                if (selectedTool != Tool.Hand &&
                    selectedTool != Tool.Pickaxe &&
                    selectedTool != Tool.Shovel &&
                    selectedTool != Tool.Axe)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You cannot choose an unknown tool!");
                    Console.ResetColor();
                    continue;
                }
            }
            catch (OverflowException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Too much! Overflow");
                Console.ResetColor();
                continue;  
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You must enter a valid number!");
                Console.ResetColor();
                continue;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e);
                Console.ResetColor();
                continue;
            }
            
            foreach (var block in world)
            {
                block.ShowInfo();
                block.Break(selectedTool);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All blocks have been destroyed!\n");
            Console.ResetColor();
        }

        Console.WriteLine("Program was finished!");
    }
}