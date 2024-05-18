namespace Design_Patterns.Structural.decorator;


// Concrete decorator 2
public class SugarDecorator: CoffeeDecorator
{
    public SugarDecorator(Coffee coffee) : base(coffee) { }
    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Sugar";
    }
    public override double GetCost()
    {
        return _coffee.GetCost() + 0.50;
    }
}