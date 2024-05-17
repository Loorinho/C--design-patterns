namespace Design_Patterns.Behavioral.chain_of_responsibility;

public class SupervisorHandler: QueryHandler
{
    public override void HandleCall(string request)
    {
        if (request == "moderate issue")
        {
            Console.WriteLine("Supervisor: Handling the call.");
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleCall(request);
        }
    }
}