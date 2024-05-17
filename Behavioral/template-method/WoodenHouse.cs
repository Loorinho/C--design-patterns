namespace Design_Patterns.Behavioral.template_method;

public class WoodenHouse: House
{
    protected override void BuildWalls()
    {
        Console.WriteLine("Adding windows for the wooden house");
    }

    protected override void BuildPillars()
    {
        Console.WriteLine("Adding pillars for the wooden house");
    }

    protected override void BuildWindows()
    {
        Console.WriteLine("Adding windows for the wooden house");
    }
}