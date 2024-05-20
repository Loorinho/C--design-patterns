namespace Design_Patterns.Structural.bridge;

public class ExtendedAbstraction: Abstraction
{
    public ExtendedAbstraction(IImplementation implementation) : base(implementation)
    {
    }
    
    // here we are overriding the virtual method
    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" +
               base._implementation.OperationImplementation();
    }
}