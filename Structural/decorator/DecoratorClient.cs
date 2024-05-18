namespace Design_Patterns.Structural.decorator;

public class DecoratorClient
{
    public void Run()
    {
        Coffee myCoffee = new SimpleCoffee();
        Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");

        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");

        myCoffee = new SugarDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} : ${myCoffee.GetCost()}");
    }
}