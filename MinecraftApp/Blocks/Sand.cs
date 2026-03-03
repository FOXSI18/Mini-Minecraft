namespace MinecraftApp.Blocks;

public class Sand : Basisblock
{
    public bool FallsDown { get; set; }

    public Sand() : base("Sand", "yellow", 3)
    {
        FallsDown = true;
    }

    public override int CalculateBreakTime(Tool tool)
    {
        if (tool == Tool.Shovel)
            return BreakTime - 2;

        return BreakTime + 1;
    }
}