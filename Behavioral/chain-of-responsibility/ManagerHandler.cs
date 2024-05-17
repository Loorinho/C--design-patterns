namespace Design_Patterns.Behavioral.chain_of_responsibility;

public class ManagerHandler: QueryHandler
{
    public override void HandleCall(string request)
    {
        if (request == "complex issue")
        {
            Console.WriteLine("Manager: Handling the call.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleCall(request);
        }
        
    }
}