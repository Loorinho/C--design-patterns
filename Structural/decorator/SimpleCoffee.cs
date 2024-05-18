namespace Design_Patterns.Structural.decorator;

// Concrete component
public class SimpleCoffee: Coffee
{
    public override string GetDescription()
    {
        return "Simple Coffee";
    }

    public override double GetCost()
    {
        return 5.00;
    }
    
}