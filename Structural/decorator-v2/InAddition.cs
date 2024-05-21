namespace Design_Patterns.Structural.decorator_v2;

public class InAddition: IDoSomething
{
    protected IDoSomething _doSomething;

    public InAddition(IDoSomething doSomething)
    {
        _doSomething = doSomething;
    }

    public void Something()
    {
        _doSomething.Something();
        Console.WriteLine("InAddition");
    }
}