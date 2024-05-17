namespace Design_Patterns.Behavioral.chain_of_responsibility;

public abstract class QueryHandler
{
    protected QueryHandler _nextHandler = null!; // It is protected so that we can access it within the subclasses

    // protected QueryHandler(QueryHandler nextHandler)
    // {
    //     _nextHandler = nextHandler;
    // }

    public void SetNextHandler(QueryHandler handler)
    {
        _nextHandler = handler;
    }

    public abstract void HandleCall(string request);
    
}