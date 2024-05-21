namespace Design_Patterns.Structural.decorator_v2;

public class AnotherThing: IDoSomething
{
    protected IDoSomething _doSomething;

    public AnotherThing(IDoSomething doSomething)
    {
        _doSomething = doSomething;
    }

    public void Something()
    {
       _doSomething.Something();
       Console.WriteLine("AnotherThing");
    }
}