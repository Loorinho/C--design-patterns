namespace Design_Patterns.Structural.bridge;

public class ConcreteImplementationA: IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform Windows OS.\n";
    }
}