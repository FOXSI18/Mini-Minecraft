using MinecraftApp.Blocks;

namespace MinecraftApp;

class Program
{
    static void Main()
    {
        Console.Clear();
        
        SlotMachine.SlotMachine myMachine = new SlotMachine.SlotMachine();
        
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Welcome to Mini Minecraft!");
        Console.WriteLine("You can choose tool to break some blocks.\nEnjoy it and don't forget about BONUS!\n");
        
        while (true)
        {
            List<Basisblock> world = new List<Basisblock>
            {
                new Sand(),
                new Wood(),
                new Iron(),
            };
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("TOOLS");
            Console.WriteLine("1 = Hand");
            Console.WriteLine("2 = Pickaxe");
            Console.WriteLine("3 = Shovel");
            Console.WriteLine("4 = Axe\n");
            Console.WriteLine("BONUS");
            Console.WriteLine("5 = Slot machine\n");
            Console.WriteLine("9 = Exit");
            Console.ResetColor();

            Tool selectedTool;

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int toolNumber)) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter a valid number.");
                Console.ResetColor();
                continue;
            }

            selectedTool = (Tool)toolNumber;
            Console.Clear();

            if (selectedTool == Tool.Exit)
                break;

            if (selectedTool == Tool.SlotM)
            {
                while (true)
                {
                    Console.WriteLine("\n1 = Rules\n2 = Play 10$\n3 = Add more money\n4 = Break");
                    
                    string slotInput = Console.ReadLine();
                    if (!int.TryParse(slotInput, out int userChoice) || userChoice < 1 || userChoice > 4) 
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter a number (1 to 4).");
                        Console.ResetColor();
                        continue;
                    }

                    if (userChoice == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("=====RULES=====");
                        Console.WriteLine("Jackpot == 9 Scores");
                        Console.WriteLine("Win >= 7 Scores");
                        Console.WriteLine("Lose <= 6 Scores");
                        Console.WriteLine("\n=====VALUES=====");
                        Console.WriteLine("Dirt = 1 Scores\nApple = 2 Scores\nDiamond = 3 Scores");
                        Console.WriteLine("Cost for one time: 10$\n");
                        Console.ResetColor();
                        continue;
                    }

                    if (userChoice == 2)
                    {
                        Console.Clear();
                        myMachine.ChooseRandomSlots();
                        continue;
                    }
                    
                    if (userChoice == 3)
                    {
                        myMachine.AddMoreMoney();
                    }

                    if (userChoice == 4)
                    {
                        Console.Clear();
                        break;
                    }
                }
                continue;
            }

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
            
            foreach (var block in world)
            {
                block.ShowInfo();
                block.Break(selectedTool);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">>> All blocks have been destroyed!\n");
            Console.ResetColor();
        }

        Console.WriteLine("Program was finished. Thanks for using the Mini Minecraft.");
    }
}