namespace Design_Patterns.Structural.decorator_v2;

public class Doer: IDoSomething
{
    public void Something()
    {
        Console.WriteLine($"Something");
    }
}