using System.Drawing;

namespace MinecraftApp.Blocks;

public class Sand : Basisblock
{
    public string Color(Color color)
    {
        Console.WriteLine(color);
        return color.ToArgb().ToString();
    }
    
}