namespace Design_Patterns.Structural.bridge;

public class Abstraction
{
    
    protected IImplementation _implementation;
        
    public Abstraction(IImplementation implementation)
    {
        this._implementation = implementation;
    }
       
    // virtual to allow a subclass to override it
    public virtual string Operation()
    {
        return "Abstract: Base operation with:\n" + 
               _implementation.OperationImplementation();
    }
    
}