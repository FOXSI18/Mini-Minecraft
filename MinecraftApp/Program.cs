using MinecraftApp.Blocks;

namespace MinecraftApp;

internal class Program
{
    private static void Main()
    {
        Basisblock block;
        var exit = false;
        ConsoleKeyInfo userChoice;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("If you want to see hotbar click 'Space'");
        Console.WriteLine("You can always press any NaN key to exit.");
        Console.ResetColor();

        do
        {
            userChoice = Console.ReadKey();

            switch (userChoice.Key)
            {
                case ConsoleKey.D1:
                    FuncKey1();
                    break;
                case ConsoleKey.D2:
                    FuncKey2();
                    break;
                case ConsoleKey.D3:
                    FuncKey3();
                    break;
                case ConsoleKey.D4:
                    FuncKey4();
                    break;
                case ConsoleKey.Spacebar:
                    ShowActions();
                    break;
                default:
                    ExitProgram();
                    break;
            }
        } while (!exit);

        void FuncKey1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[1:Hand] ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[2:Pickaxe] [3:Shovel] [4:Axe]");
            Console.ResetColor();
        }

        void FuncKey2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[1:Hand] ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[2:Pickaxe] ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[3:Shovel] [4:Axe]");
            Console.ResetColor();
        }

        void FuncKey3()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[1:Hand] [2:Pickaxe] ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[3:Shovel] ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[4:Axe]");
            Console.ResetColor();
        }

        void FuncKey4()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[1:Hand] [2:Pickaxe] [3:Shovel] ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[4:Axe]");
            Console.ResetColor();
        }

        void ShowActions()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[1:Hand] [2:Pickaxe] [3:Shovel] [4:Axe]");
            Console.ResetColor();
        }

        void ExitProgram()
        {
            Console.Clear();

            Console.WriteLine("Are you sure that you exit want? Y/N");
            var exitChoice = Console.ReadKey();

            switch (exitChoice.Key)
            {
                case ConsoleKey.Y:
                    exit = true;
                    break;
                case ConsoleKey.N:
                    exit = false;
                    Console.Clear();
                    Main();
                    break;
                default:
                    ExitProgram();
                    break;
            }
        }
        
        /*block.Info();
        Console.WriteLine();
        block.Broken();
        Console.WriteLine();*/
    }
}