namespace Design_Patterns.Structural.decorator;


// Concrete decorator 1
public class MilkDecorator: CoffeeDecorator
{
    public MilkDecorator(Coffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 1.50;
    } 
}