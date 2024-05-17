namespace Design_Patterns.Behavioral.chain_of_responsibility;

public interface IHandler
{
    // protected IHandler _nextHandler;

    // public void SetNextHandler(CallHandler handler)
    // {
    //     _nextHandler = handler;
    // }

    public abstract void HandleCall(string request);
}