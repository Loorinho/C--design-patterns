namespace Design_Patterns.Behavioral.chain_of_responsibility;

public class OperatorHandler: QueryHandler
{
    public override void HandleCall(string request)
    {
        if (request == "simple issue")
        {
            Console.WriteLine("Operator: Handling the call.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleCall(request);
        }
    }
}