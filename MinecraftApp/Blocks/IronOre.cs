namespace MinecraftApp.Blocks;

public class IronOre : Basisblock
{
    public bool IsHard { get; set; }

    public IronOre() : base("Iron Ore", "gray", 8)
    {
        IsHard = true;
    }
    
     public override int CalculateBreakTime(Tool tool)
    {
        if (tool == Tool.Pickaxe)
            return BreakTime - 5;

        return BreakTime + 3;
    }
}