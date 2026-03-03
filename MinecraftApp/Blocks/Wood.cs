namespace MinecraftApp.Blocks;

public class Wood : Basisblock
{
     public bool IsFlammable { get; set; }
        public Wood() : base("Wood", "brown", 5)
    {
        IsFlammable = true;
    }
    
     public override int CalculateBreakTime(Tool tool)
    {
        if (tool == Tool.Axe)
            return BreakTime - 4;

        return BreakTime + 2;
    }
}