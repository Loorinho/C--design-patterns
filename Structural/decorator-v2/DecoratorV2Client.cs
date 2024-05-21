namespace Design_Patterns.Structural.decorator_v2;

public class DecoratorV2Client
{
    public void Run()
    {
        var doer = new Doer();
        doer.Something();

        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
        
        var anotherThing = new AnotherThing(doer);
        anotherThing.Something();
        
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");

        
        var inAddition = new InAddition(anotherThing);
        inAddition.Something();
        
        Console.WriteLine("+++++++++++++++++ Overall ++++++++++++++++++++++++");

        var overall = new InAddition(new AnotherThing(new Doer()));
        overall.Something();
    }
}